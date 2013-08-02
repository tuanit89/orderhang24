<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChildPage.aspx.cs" Inherits="ChildPage" %>
<%@ Register src="~/Controls/sidebar.ascx" tagName="category" tagPrefix="usc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <usc:category runat="server" />
    <div class="list-news-child">
        <%
            for (int i = 0; i < Categories.Count; i++)
            {%>
               <div class="item">
                <div class="img-dv">
                    <a href="#"><img  src="Styles/images/img-list-news.png"/></a>
                </div>
                <div class="text">
                    <a class="title" href="#">Galaxy Order</a>
                    <div class="detail">Meo nho giup chung minh Meo nho giup chung minh Meo nho giup chung minh Meo nho giup chung minh Meo nho giup chung minh</div>
                    <a class="view-more" href="#">Xem tiếp...</a>
                </div>
                <div class="clear"></div>
            </div> 
         <% }    
         %>
            
        </div>
</asp:Content>

