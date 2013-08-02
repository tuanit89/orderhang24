<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sidebar.ascx.cs" Inherits="Website.Controls.sidebar" %>
<div class="childpage">
    <div class="menu-category">
        <p class="title">Danh Mục sản phẩm</p>
        <ul>
            <li class="active"><a href="#">Giày thể thao</a></li>
            <% foreach (var category in Categories)
               { %>
                    <li><a href="<%= category.Link %>"><%= category.Name %></a></li>
               <%} %>
            <li class="last"><a href="#">Giày thể thao</a></li>
        </ul>
    </div>
    <!-- END MENU -->
</div>

