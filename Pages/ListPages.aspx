<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPages.aspx.cs" Inherits="Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Page List</h2>
    <ul id="pages" runat="server">

    </ul>
    <a href="NewPage.aspx">Add a new page</a>
</asp:Content>
