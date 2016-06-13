using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVPSoC.Models;

namespace MVPSoC
{
    public partial class EmployeeList : System.Web.UI.Page,IEmployeeSearchView
    {
        public event EventHandler<DepartmentSelectedEventArgs> DepartmentSelected;
        public EmployeeSearchPresenter Presenter { get; private set; }
        public EmployeeList()
        {
            Presenter = new EmployeeSearchPresenter(this);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                this.Presenter.Initialize();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string department = this.DropDownListDepartments.SelectedValue;
            DepartmentSelectedEventArgs eventArgs = new DepartmentSelectedEventArgs(department);
            if (null != DepartmentSelected)
            {
                DepartmentSelected(this, eventArgs);
            }
        }

        public void BindEmployees(IEnumerable<Employee> employees)
        {
            this.GridViewEmployees.DataSource = employees;
            this.GridViewEmployees.DataBind();
        }

        public void BindDepartments(IEnumerable<string> departments)
        {
            this.DropDownListDepartments.DataSource = departments;
            this.DropDownListDepartments.DataBind();
        }
    }
}