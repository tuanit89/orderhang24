<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" Inherits="ChildPage" Codebehind="ChildPage.aspx.cs" %>
<%@ Register src="~/Controls/sidebar.ascx" tagName="category" tagPrefix="usc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <usc:category runat="server" />
    <div class="list-news-child">
        <div class="breadcump">
                        <span>Bạn đang ở: </span>
                        <a href="#">Trang chủ</a> > 
                        <a href="#">Hỏi đáp</a> > 
                        <a href="#">Liên hệ</a>
                    </div>
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

