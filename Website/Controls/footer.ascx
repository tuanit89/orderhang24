<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="footer.ascx.cs" Inherits="tratancuonghoangbinh.Controls.footer" %>
<div id="footer">
    <div class="innerdiv">
        <ul id="foot-nav">
            <li><a href="/" class="mainlevel-nav">Trang chủ</a></li>
            <li><a href="/tra-va-suc-khoe-cn10.aspx" class="mainlevel-nav">Trà và sức khỏe</a></li>
            <li><a href="/tin-tuc.aspx" class="mainlevel-nav">Tin tức</a></li>
            <li><a href="/gioi-thieu.aspx" class="mainlevel-nav">Giới thiệu</a></li>
            <li><a href="/lien-he.aspx" class="mainlevel-nav">Liên hệ</a></li>
            <li><a href="/thanh-toan.aspx" class="mainlevel-nav">Thanh toán</a></li>
            <li><a href="/che-tan-cuong-cp24.aspx" class="mainlevel-nav"><strong>Chè tân cương</strong></a></li>
        </ul>
        <div class="clear">
        </div>
        <div class="custom-footer">
            <%= BindCustomFooter() %>
        </div>
        <p id="copyright">
            ©
            <%= DateTime.Now.Year %>
            <a href="/" title="Trà Tân Cương Minh Thu">TraMinhThu.Com</a>. All Rights Reserved - Developed by tuan.it89</p>
    </div>
</div>
