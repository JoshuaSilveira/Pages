<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowPage.aspx.cs" Inherits="Pages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="page" runat="server">
        <h1 id="title" runat="server"></h1>
        <p id="content" runat="server"></p>
    </div>
    <asp:Button OnClick="updatePage" runat="server" Text="Update This page?" />

    <asp:Button OnClick="deletePage" runat="server" Text="Delete This page?" />
</asp:Content>
