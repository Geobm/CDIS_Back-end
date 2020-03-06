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
                 <asp:TextBox ID="txtCode"  MaxLength ="6" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCode" runat="server" ControlToValidate="txtCode"
                        ErrorMessage="Code required"  ValidationGroup="vg1" Display ="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCode" runat="server" ControlToValidate="txtCode"
                         ValidationExpression="[A-Z]{4}\d{2}"  ValidationGroup="vg1" 
                          Display ="Dynamic" ErrorMessage="The format must be 4 capital letters and 2 numbers."></asp:RegularExpressionValidator>
            </td>
        <tr>
            <td> Name: </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtCode"
                        ErrorMessage="Name required"  ValidationGroup="vg1" Display ="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> Creation Date: </td>
            <td>
                <asp:TextBox ID="txtCreationDate" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvCreationDate" runat="server" ControlToValidate="txtCreationDate"
                       ErrorMessage="Creation date required" ValidationGroup="vg1"  Display="Dynamic" ></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="DateCV" runat="server"  ControlToValidate="txtCreationDate" 
                        Type="Date" Operator="DataTypeCheck" ValidationGroup="vg1"
                       Display ="Dynamic" ErrorMessage="Incorrect format (dd-mm-yyyy)"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td> Select University: </td>
            <td>
                <asp:DropDownList ID="ddlUniversity" CssClass="Lista" runat="server"></asp:DropDownList>
            </td>
        </tr>
                
        <tr>
            <td>State: </td>
            <td>
                <asp:DropDownList ID="ddlState" CssClass="Lista" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>City: </td>
            <td>
                <asp:DropDownList ID="ddlCity" CssClass="Lista" runat="server" ></asp:DropDownList>
            </td>
        </tr>


        <tr>
            <td></td>
            <td>
            <asp:Button ID ="Edittbn" runat="server" Text="Edit" ValidationGroup="vg1" OnClick="Edittbn_Click"/>
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
