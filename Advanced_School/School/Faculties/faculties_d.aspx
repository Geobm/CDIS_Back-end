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
                <asp:DropDownList ID="ddlUniversity" CssClass="Lista" runat="server" Enabled ="false"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
            <asp:Button ID ="Deletebtn" runat="server" Text="Delete" OnClick="Deletebtn_Click" />
            </td>
        </tr>

    </table> 
     <script type="text/javascript">
    
        $(document).ready(function () {

            $("#MainContent_txtCreationDate").datepicker({
                
                changeMonth: true,
                changeYear: true,
                yearRange: "1900:2010",
                dateFormat : "dd-mm-yy"
            });

            $(".Lista").chosen();

            var manager = Sys.WebForms.PageRequestManager.getInstance();
            manager.add_endRequest(function () {

                $("#MainContent_txtCreationDate").datepicker({

                    changeMonth: true,
                    changeYear: true,
                    yearRange: "1900:2010",
                    dateFormat: "dd-mm-yy"
                });

                $(".Lista").chosen();
            });
        });
    </script>
</asp:Content>
