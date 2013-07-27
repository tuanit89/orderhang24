<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChildPage.aspx.cs" Inherits="ChildPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="childpage">
        <div class="menu-category">
            <p class="title">Danh Mục sản phẩm</p>
            <ul>
                <li><a href="#">Giày thể thao</a></li>
                <li><a href="#">Giày thể thao</a></li>
                <li class="active"><a href="#" >Giày thể thao</a></li>
                <li><a href="#">Giày thể thao</a></li>
                <li><a href="#">Giày thể thao</a></li>
                <li><a href="#">Giày thể thao</a></li>
                <li><a href="#">Giày thể thao</a></li>
                <li><a href="#">Giày thể thao</a></li>
                <li class="last"><a href="#">Giày thể thao</a></li>
            </ul>
        </div>
        <!-- END MENU -->
        <div class="news-recent">
            <p class="title">Bài viết  phổ biến từ blog kinh doanh</p>
            <div class="item">
                <p><a href="#">What Must an Educated Person Know?</a>
                 - Investment in learning skills related to these areas are most likely to pay dividends in real-world situations.</p>
            </div>
            <div class="item">
                <p><a href="#">What Must an Educated Person Know?</a>
                 - Investment in learning skills related to these areas are most likely to pay dividends in real-world situations.</p>
            </div>
            <div class="item">
                <p><a href="#">What Must an Educated Person Know?</a>
                - Investment in learning skills related to these areas are most likely to pay dividends in real-world situations.</p>
            </div>
        </div>        
    </div>
    <div class="list-news-child">
        <%
            for (int i = 0; i < 7; i++)
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

