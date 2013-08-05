<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="tratancuonghoangbinh.Controls.header" %>
<%@ Register src="Sliderbody.ascx" tagPrefix="usc" tagName="slider" %>
<div class="header">
    <div class="bg-header">
        <h2>
            <a href="/" class="clear-fix">
                <img src="/Content/images/logo.png" class="logo" alt="" style="float: left;margin-right: 25px;" />
                <img src="/Content/images/logo2.png" style="float: left"/>
            </a>
        </h2>
    </div>
    <div class="menu">
        <ul>
            <li class="active"><a href="/" class="home active">Trang chủ</a></li>
            <li><a href="/huong-dan.htm">Hướng dẫn</a></li>
            <li><a href="/bao-gia.htm">Báo giá</a></li>
            <li><a href="/san-pham.htm">Sản phẩm</a></li>
            <li><a href="/kinh-nghiem.htm">Kinh nghiệm</a></li>
            <li><a href="/blog.htm">Blog</a></li>
            <li><a href="/gioi-thieu.htm">Giới thiệu</a></li>
            <li><a href="/hoi-dap.htm">Hỏi đáp</a></li>
            <li><a href="/lien-he.htm">Liên hệ</a></li>
        </ul>
        <div class="clear">
        </div>
    </div>

    <!--slider-->
    <usc:slider runat="server" />
</div>
<!-- END HEADER -->
