<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="faculty_i.aspx.cs" Inherits="School.Faculties.faculty_i" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        
        <tr>
            <td> Code: </td>
            <td>
                <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
            </td>
        </tr>
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
            <asp:Button ID ="Addbtn" runat="server" Text="Add Faculty" OnClick="Addbtn_Click"/>
            </td>
        </tr>



    </table>

</asp:Content>
