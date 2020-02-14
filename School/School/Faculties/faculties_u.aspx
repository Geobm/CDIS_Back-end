<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="faculties_u.aspx.cs" Inherits="School.Faculties.faculties_u" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <table>
        
        <tr>
            <td> ID Faculty: </td>
            <td>
                <asp:Label ID="lblID_Faculty" runat="server" Text=""></asp:Label>
            </td>
        </tr>
         <td> Code: </td>
            <td>
                 <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
            </td>
        <tr>
            <td> Name: </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td> Creation Date: </td>
            <td>
                <asp:TextBox ID="txtCreationDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td> Select University: </td>
            <td>
                <asp:DropDownList ID="ddlUniversity" runat="server"></asp:DropDownList>
            </td>
        </tr>
        
        <tr>
            <td></td>
            <td>
            <asp:Button ID ="Edittbn" runat="server" Text="Edit" OnClick="Edittbn_Click"/>
            </td>
        </tr>



    </table> 
</asp:Content>
