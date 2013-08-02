<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_header.ascx.cs"
            Inherits="tratancuonghoangbinh.Controls.admin_header" %>
<div id="header" class="clearfix">
    <div class="w96percent">
         <ul>
            <li>Xin chào <strong><%= Username %></strong></li>
            <li id="logout"><a href="logout.aspx">Đăng xuất</a></li>
            <li id="viewWS"><a href="/" title="Xem website" target="_blank">Xem website</a></li>
            <li id="yahoosupport">
                <div id="showyahoosupport">
                        <strong>Mọi thắc mắc hỗ trợ xin liên hệ số điện thoại 0985 032 797</strong><br/>
                        <p style="text-align: center">
                            <a class="yahoo" href="ymsgr:sendIM?tuan.it89"><img border="0" align="absmiddle" alt="Chat Yahoo" src="http://opi.yahoo.com/online?u=tuan.it89&amp;m=g&amp;t=1"></a>
                            <a class="skype" href="skype:tuancva211?call"><img src="/Content/admin/skype64.png"></a>
                        </p>
                </div>
                <a href="javascript:void(0);" id="need-support">Bạn cần hỗ trợ?</a> </li>
        </ul>
        <div class="clear"></div>
        <div class="userstatus">
            Hình thức sử dụng: <span style="font-weight: bold; font-style: italic;">Mãi mãi</span>
            | Khởi tạo 01/11/2012
        </div>
        <!--navigate-->
        <div id="navi" class="clearfix">
            <ul id="navigate">
                <li><a data-name="home" class="active" href="/admin/">Tổng quan</a></li>
                <li>
                    <a data-name="product" href="list-product.aspx">Sản phẩm</a>
                    <ul>
                        <li><a class="icon_add" href="edit-product.aspx">Thêm sản phẩm</a></li>
                        <li><a class="icon_list" href="list-product.aspx">Danh sách sản phẩm</a></li>
                        
                        <li><a class="icon_category" href="list-category-product.aspx">Danh mục sản phẩm</a></li>
                        <li><a class="icon_add" href="edit-category-product.aspx">Thêm danh mục sản phẩm</a></li>
                        
                       <%-- <li><a class="icon_category" href="list-supplier-product.aspx">Danh sách nhà cung cấp</a></li>
                        <li><a class="icon_add" href="edit-supplier-product.aspx">Thêm nhà cung cấp</a></li>--%>
                        
                        <li><a class="icon_category" href="feature-product.aspx">Quản lý tính năng nhóm</a></li>
                        <li><a class="icon_category" href="feature-value-product.aspx">Quản lý thuộc tính</a></li>
                        
                    </ul>
                </li>
                <li>
                    <a data-name="news" href="list-news.aspx">Tin tức</a>
                    <ul>
                        <li><a class="icon_add" href="edit-news.aspx">Tạo tin</a></li>
                        <li><a class="icon_list" href="list-news.aspx">Quản lý tin</a></li>
                        <li><a class="icon_add" href="edit-category-news.aspx">Thêm mới nhóm tin</a></li>
                        <li><a class="icon_list" href="list-category-news.aspx">Danh mục tin</a></li>
                    </ul>
                </li>
                <li>
                    <a data-name="column" href="list-image-column.aspx">Khối hình ảnh</a>
                    <ul>
                        <li><a class="icon_add" href="edit-image-column.aspx">Tạo khối</a></li>
                        <li><a class="icon_list" href="list-image-column.aspx">Quản lý khối</a></li>
                    </ul>
                </li>
                <li>
                    <a data-name="slideshow" href="list-download.aspx">Slide show</a>
                    <ul>
                        <li><a class="icon_add" href="edit-slideshow.aspx">Tạo mới</a></li>
                        <li><a class="icon_list" href="list-slideshow.aspx">Quản lý </a></li>
                    </ul>
                </li>
                <li>
                    <a data-name="ad" href="list-ad.aspx">Quảng cáo</a>
                    <ul>
                        <li><a class="icon_add" href="edit-ad.aspx">Thêm quảng cáo</a></li>
                        <li><a class="icon_list" href="list-ad.aspx">Danh sách quang cáo</a></li>
                    </ul>
                </li>
                <li>
                    <a data-name="user" href="list-user.aspx">Quản lý người dùng</a>
                    <ul>
                        <li><a class="icon_list" href="list-user.aspx">Danh sách</a></li>
                        <li><a class="icon_add" href="edit-user.aspx">Thêm mới</a></li>
                        <li><a class="icon_sms" href="update-profile-user.aspx">Cập nhật thông tin cá nhân</a></li>
                    </ul>
                </li>
                <li>
                    <a data-name="support" href="list-support.aspx">Hỗ trợ trực tuyến</a>
                    <ul>
                        <li><a class="icon_list" href="list-support.aspx">Danh sách hỗ trợ viên</a></li>
                        <li><a class="icon_add" href="edit-support.aspx">Thêm mới</a></li>
                    </ul>
                </li>
                <li>
                    <a data-name="other">Cài đặt chung</a>
                    <ul>
                        <li><a class="icon_support" href="feedback-other.aspx">Quản lý phản hồi liên hệ</a></li>
                        <li><a class="icon_footer" href="edit-template-other.aspx">Thay đổi vùng website</a></li>
                        <li><a class="icon_order" href="seo-other.aspx">Seo toàn trang</a></li>
                        <li><a class="icon_adz" href="list-slideshow.aspx">Thay đổi slide chạy</a></li>
                        <li><a class="icon_stats" href="download-other.aspx">Up file mẫu</a></li>
                        <li><a class="icon_config" href="list-settings-other.aspx">Cấu hình website</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
</div>