using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVCRoute
{
    public partial class UriHelperAction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpRequest request = new HttpRequest("UriHelperAction.aspx", "http://localhost:60019/home/index/002", null);
            HttpResponse response = new HttpResponse(new StringWriter());
            HttpContext context = new HttpContext(request, response);
            HttpContextBase contextBase = new HttpContextWrapper(context);

            RouteData routeData = new RouteData();
            routeData.Values.Add("action", "index");
            routeData.Values.Add("controller", "home");
            routeData.Values.Add("id", "002");

            RequestContext requestContext = new RequestContext(contextBase, routeData);
            RouteHelper helper = new RouteHelper(requestContext);
            
            Response.Write(helper.Action("GetProduct") + "<br/>");
            Response.Write(helper.Action("GetProduct", "Products") + "<br/>");
            Response.Write(helper.Action("GetProduct", "Products", new { id = "002" }) + "<br/>");
            Response.Write(helper.Action("GetProduct", "Products", new { id = "002" },"https") + "<br/>");
            Response.Write(helper.Action("GetProduct", "Products", new RouteValueDictionary { { "id","002"} }, "http","www.baidu.com") + "<br/>");
        }
    }
}