<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Website.admin._default" %>
<%@Register tagPrefix="usc" tagName="sideLeft" src="~/Controls/admin_option_left.ascx" %>
<%@Register tagPrefix="usc" tagName="sideRight" src="~/Controls/admin_option_right.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="innerDefault clearfix">
       <usc:sideLeft runat="server" />
       <usc:sideRight runat="server" />
       <div class="clear"></div>
   </div>
</asp:Content>
