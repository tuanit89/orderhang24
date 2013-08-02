<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Content.aspx.cs" Inherits="Content" %>
<%@ Register src="Controls/sidebar.ascx" tagName="menu" tagPrefix="usc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!-- Category-->
    <usc:menu runat="server" />
    <div class="list-news-child">
        <p class="title-content">Galaxy Order Galaxy Order</p>
        <p class="date-content">Đăng ngày 4-7-2013</p>
        <div class="detail-content">Cách làm</div>
    </div>
</asp:Content>

