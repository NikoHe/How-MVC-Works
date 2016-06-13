using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVPSoC.Models;
using Microsoft.Practices.Unity.Utility;

namespace MVPSoC
{
    public interface IEmployeeSearchView
    {
        void BindEmployees(IEnumerable<Employee> employees);
        void BindDepartments(IEnumerable<string> departments);
        event EventHandler<DepartmentSelectedEventArgs> DepartmentSelected;
    }

    public class DepartmentSelectedEventArgs : EventArgs
    {
        public string Department { get; private set; }
        public DepartmentSelectedEventArgs(string department)
        {
            Guard.ArgumentNotNullOrEmpty(department, "department");
            this.Department = department;
        }
    }
}