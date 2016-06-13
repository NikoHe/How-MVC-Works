using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVCRoute
{
    public partial class Default : Page
    {
        private EmployeeRepository repository;
        public EmployeeRepository Repository
        {
            get { return null==repository?repository=new EmployeeRepository():repository; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            string employeeId = this.RouteData.Values["Id"] as string;
            if (employeeId == "*" || string.IsNullOrEmpty(employeeId))
            {

                this.GridViewEmployees.Visible = true;
                this.GridViewEmployees.DataSource = this.Repository.GetEmployees();
                this.GridViewEmployees.DataBind();
                this.DetailsViewEmployee.Visible = false;
            }
            else
            {
                this.DetailsViewEmployee.Visible = true;
                var employees = this.Repository.GetEmployees(employeeId);
                this.DetailsViewEmployee.DataSource = employees;
                this.DetailsViewEmployee.DataBind();
                this.GridViewEmployees.Visible = false;
            }
        }
    }
}