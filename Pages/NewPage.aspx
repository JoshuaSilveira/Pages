<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewPage.aspx.cs" Inherits="Pages.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>New Page</h2>
    <div class="form-group">
        <label for="page_title">Enter a page title:</label>
        <asp:TextBox  runat="server" class="form-control" ID="page_title"></asp:TextBox>
        <label for="page_content">Enter content:</label>
        <asp:TextBox TextMode="multiline" Columns="50" Rows="5"  runat="server" class="form-control" ID="page_content"></asp:TextBox>
    </div>
     <asp:Button OnClick="addPage" Text="Add Page" runat="server" />
</asp:Content>
