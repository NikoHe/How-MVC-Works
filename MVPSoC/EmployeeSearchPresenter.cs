using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVPSoC.Models;

namespace MVPSoC
{
    public class EmployeeSearchPresenter
    {
        public IEmployeeSearchView View { get; private set; }
        public EmployeeRepository Respository { get; private set; }

        public EmployeeSearchPresenter(IEmployeeSearchView view)
        {
            this.View = view;
            this.Respository = new EmployeeRepository();
            this.View.DepartmentSelected += OnDepartmentSelected;
        }

        public void Initialize()
        {
            IEnumerable<Employee> employees = this.Respository.GetEmployees();
            this.View.BindEmployees(employees);
            string[] department = new string[] { "销售部", "采购部", "人事部", "IT部" };
            this.View.BindDepartments(department);
        }
        private void OnDepartmentSelected(object sender, DepartmentSelectedEventArgs e)
        {
            string department = e.Department;
            var employees = this.Respository.GetEmployees(department);
            this.View.BindEmployees(employees);
        }
    }
}