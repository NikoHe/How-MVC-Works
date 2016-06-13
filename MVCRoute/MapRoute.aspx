<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MapRoute.aspx.cs" Inherits="MVCRoute.MapRoute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Route:</td>
                    <td><%=GetRouteData().Route != null?GetRouteData().Route.GetType().FullName:"" %></td>
                </tr>
                <tr>
                    <td>RouteHandler:</td>
                    <td><%=GetRouteData().RouteHandler != null?GetRouteData().RouteHandler.GetType().FullName:"" %></td>
                </tr>
                <tr>
                    <td>Values:</td>
                    <td>
                        <ul>
                            <%foreach (var variable in GetRouteData().Values)
                                { %>
                            <li><%=variable.Key %>=<%=variable.Value %></li>
                            <%} %>
                        </ul>
                    </td>
                </tr>
                <tr>
                    <td>DataToken:</td>
                    <td>
                        <ul>
                            <%foreach (var token in GetRouteData().DataTokens)
                                { %>
                            <li><%=token.Key %>=<%=token.Value %></li>
                            <%} %>
                        </ul>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
