using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace MVCRoute
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            //RouteTable.Routes.MapRoute("default", "{controller}/{action}/{id}");
            RouteTable.Routes.MapRoute("default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "001" });
            //AreaRegistration.RegisterAllAreas();
            //RouteTable.Routes.RouteExistingFiles = true;
            //RouteTable.Routes.Ignore("{filename}.js/{*pathInfo}");
            //var defaults = new RouteValueDictionary { { "areacode", "010" }, { "days", 2 } };
            //object defaults = new { areacode = "010", days = 2, defaultCity = "Beijing", defaultDays = 2 };
            //var constraints = new RouteValueDictionary { { "areacode", @"0\d{2,3}" }, { "days", @"[1-3]{1}" } };
            //object constraints = new { areacode = @"0\d{2,3}", days = @"[1-3]{1}" };
            //var dataTokens = new RouteValueDictionary { { "defaultCity", "Beijing" }, { "defaultDays", 2 } };
            //string[] namespaces = new string[] { "MVCRoute.MapRoute", "MVCRoute.MapRoute.Html" };

            //RouteTable.Routes.MapPageRoute("default", "{areacode}/{days}", "~/Weather.aspx", false, defaults, constraints, dataTokens);
            //RouteTable.Routes.MapRoute("default", "{areacode}/{days}", defaults, constraints, namespaces);
        }
    }
    // Code that runs on application startup
    //RouteConfig.RegisterRoutes(RouteTable.Routes);
    //BundleConfig.RegisterBundles(BundleTable.Bundles);
    //var defaults = new RouteValueDictionary { { "name", "*" }, { "id", "*" } };
    //RouteTable.Routes.MapPageRoute("", "employees/{name}/{id}", "~/Default.aspx", true, defaults);
    //RouteTable.Routes.MapPageRoute("", "employeesddd/{name}/{id}", "~/Default.aspx", true, defaults);
    //RouteTable.Routes.RouteExistingFiles = true;
    //RouteTable.Routes.Ignore("{filename}.js/{*pathInfo}");
    //var defaults = new RouteValueDictionary { { "areacode", "010" }, { "days", 2 } };
    //var constraints = new RouteValueDictionary { { "areacode", @"0\d{2,3}" }, { "days", @"[1-3]{1}" }, { "httpMethod", new HttpMethodConstraint("POST") } };
    //var dataTokens = new RouteValueDictionary { { "defaultCity", "Beijing" }, { "defaultDays", 2 } };
    //路由注册方式1
    //RouteTable.Routes.MapPageRoute("default", "{areacode}/{days}", "~/Weather.aspx", false, defaults, constraints, dataTokens);
    //路由注册方式2
    //Route route = new Route("{areacode}/{days}", defaults, constraints, dataTokens, new PageRouteHandler("~/weather.aspx", false));
    //RouteTable.Routes.Add(route);
}