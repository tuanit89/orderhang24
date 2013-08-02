<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_option_right.ascx.cs" Inherits="Website.Controls.admin_option_right" %>
<div id="optSideRight" class="clearfix">
    <div class="itemsRight">
        <h4>Thống kê website</h4>
        <div class="itemsRightCenter clearfix">
            <a class="clearfix"><span class="sepRight">Số sản phẩm</span><span class="alnright"><%= ProductCounter() %></span></a>
            <a class="clearfix"><span class="sepRight">Số tin tức</span><span class="alnright"><%= NewsCounter() %></span></a>
        </div>
    </div>
    <%--<div class="itemsRight">
        <h4>Thông tin website</h4>
        <div class="itemsRightCenter clearfix">
            <div style="text-align: center">
                <img src="/Content/admin/1067901_100.png"/>
                 <a href="#">Thay đổi logo</a>
            </div>
            
            <p>iUniform</p>
            <p>Trang đồng phục chuyên biệt tuổi teen</p>
        </div>
    </div>--%>
</div>