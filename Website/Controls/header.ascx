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
            <li><a href="/huong-dan.aspx">Hướng dẫn</a></li>
            <li><a href="/bao-gia.aspx">Báo giá</a></li>
            <li><a href="/san-pham.aspx">Sản phẩm</a></li>
            <li><a href="/kinh-nghiem.aspx">Kinh nghiệm</a></li>
            <li><a href="/blog.aspx">Blog</a></li>
            <li><a href="/gioi-thieu.aspx">Giới thiệu</a></li>
            <li><a href="/hoi-dap.aspx">Hỏi đáp</a></li>
            <li><a href="/lien-he.aspx">Liên hệ</a></li>
        </ul>
        <div class="clear">
        </div>
    </div>

    <!--slider-->
    <usc:slider runat="server" />
</div>
<!-- END HEADER -->
