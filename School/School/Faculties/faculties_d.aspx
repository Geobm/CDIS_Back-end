<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="faculties_d.aspx.cs" Inherits="School.Faculties.faculties_d" %>
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
                <asp:Label ID="lblCode" runat="server" Text=""></asp:Label>
            </td>
        <tr>
            <td> Name: </td>
            <td>
                <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td> Creation Date: </td>
            <td>
                <asp:Label ID="lblCreation_date" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td> Select University: </td>
            <td>
                <asp:DropDownList ID="ddlUniversity" runat="server" Enabled ="false"></asp:DropDownList>
            </td>
        </tr>
        
        <tr>
            <td></td>
            <td>
            <asp:Button ID ="Deletebtn" runat="server" Text="Delete" OnClick="Deletebtn_Click" />
            </td>
        </tr>



    </table> 
</asp:Content>
