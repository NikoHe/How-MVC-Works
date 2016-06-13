using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
//using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using MiniMVCLib;

namespace MiniMVC
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteTable.Routes.Add("default", new Route { Url = "{controller}/{action}" });
            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory());
            ControllerBuilder.Current.DefaultNamespaces.Add("MiniMVC");
        }
    }
}