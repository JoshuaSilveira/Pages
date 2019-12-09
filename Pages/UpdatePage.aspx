<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Pages.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Update Page</h2>
    <div class="form-group">
        <label for="page_title">Enter a page title:</label>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="page_title" ID="page_title_validator" ErrorMessage="Please enter a page title!"></asp:RequiredFieldValidator>
        <asp:TextBox  runat="server" class="form-control" ID="page_title"></asp:TextBox>
        <label for="page_content">Enter content:</label>
        <asp:TextBox TextMode="multiline" Columns="50" Rows="5"  runat="server" class="form-control" ID="page_content"></asp:TextBox>
    </div>
     <asp:Button OnClick="updatePage" Text="Update Page" runat="server" />
</asp:Content>
