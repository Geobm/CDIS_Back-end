<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="School.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/Login.css" rel="stylesheet" />
</head>
<body>
    <form id="formLogin" runat="server">
      <div id ="imgLogin"></div>
        <table>
         <td> User name: </td>
            <td>
                 <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        <tr>
            <td> Password: </td>
            <td>
                <asp:TextBox ID="txtPassword" TextMode = "Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
            <asp:Button ID ="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />
            </td>
        </tr>

    </table>
    </form>
</body>
</html>
