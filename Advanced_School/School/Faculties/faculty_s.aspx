<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="faculty_s.aspx.cs" Inherits="School.Faculties.faculty_s" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="grd_faculties" AutoGenerateColumns ="false" runat="server" OnRowCommand="grd_faculties_RowCommand">
        <Columns>
             <%--Edit Button--%>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="Editbtn" runat="server" ImageUrl="/Images/Edit.png" height ="20px" Width="20px" 
                        CommandName="Edit" CommandArgument='<%#Eval("ID_Faculty") %>'/>
                </ItemTemplate>
            </asp:TemplateField>

            <%--Delete Button--%>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="Deletebtn" runat="server" ImageUrl="/Images/Delete.png" height ="20px" Width="20px" 
                        CommandName="Delete" CommandArgument='<%#Eval("ID_Faculty") %>'/>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField HeaderText =" ID " DataField ="ID_Faculty" />
            <asp:BoundField HeaderText =" Code " DataField ="Code" />
            <asp:BoundField HeaderText =" Name " DataField ="Name" />
            <asp:BoundField HeaderText =" Creation date " DataField ="Creation_date" DataFormatString="{0:dd/MM/yyyy}"/>
            <asp:BoundField HeaderText =" University " DataField ="UniversityName" />
            <asp:BoundField HeaderText =" City " DataField ="CityName" />
        </Columns>

    </asp:GridView>
</asp:Content>
