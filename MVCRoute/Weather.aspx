<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="MVCRoute.Weather" %>

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
                    <td><%=RouteData.Route != null?RouteData.Route.GetType().FullName:"" %></td>
                </tr>
                <tr>
                    <td>RouteHandler:</td>
                    <td><%=RouteData.RouteHandler !=null?RouteData.RouteHandler.GetType().FullName:"" %></td>
                </tr>
                <tr>
                    <td>Values:</td>
                    <td>
                        <ul>
                            <%foreach (var item in RouteData.Values)
                                { %>
                            <li><%=item.Key %> = <%=item.Value %></li>
                            <%} %>
                        </ul>
                    </td>
                </tr>
                <tr>
                    <td>DataTokens:</td>
                    <td>
                        <ul>
                            <%foreach (var item in RouteData.DataTokens)
                                { %>
                            <li><%=item.Key %>=<%=item.Value %></li>
                            <%} %>
                        </ul>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
