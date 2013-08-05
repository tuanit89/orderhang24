<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="True" CodeBehind="NewsDetail.aspx.cs" Inherits="NewsDetail" %>
<%@ Register src="Controls/sidebar.ascx" tagName="menu" tagPrefix="usc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!-- Category-->
    <usc:menu runat="server" />
    <div class="list-news-child">
        <h2 class="breadcump">
            <span>Bạn đang ở: </span>
            <%= BreadCumps %>
        </h2>
        <h1 class="title-content"><%= NewsInfo.Title %></h1>
        <p class="date-content">Đăng ngày <%= NewsInfo.CreateDate.ToString("dd - MM - yyyy") %></p>
         <div class="social-detail">
            <!-- AddThis Button BEGIN -->
            <div class="addthis_toolbox addthis_default_style ">
                <a class="addthis_button_facebook_like" <%= "fb:like:layout=\"button_count\""%>></a><a class="addthis_button_tweet"></a>
                <a class="addthis_button_pinterest_pinit"></a>
                <a class="addthis_counter addthis_pill_style"></a>
                <a class="addthis_button_google_plusone" <%= "g:plusone:size=\"medium\""%>></a>  
            </div>
            <script type="text/javascript">var addthis_config = { "data_track_addressbar": false };</script>
            <script type="text/javascript" src="//s7.addthis.com/js/300/addthis_widget.js#pubid=ra-4f2762d733ded547"></script>
            <!-- AddThis Button END -->
        </div>
        <p class="newsdescription">
            <%= NewsInfo.Description %>
        </p>
        <div class="detail-content">
            <%= NewsInfo.Content %>
        </div>
        <a href="/" title="Trở lại trang chủ" style="display: block;text-align: right">[- Trở lại trang chủ -]</a>
        <div class="facebook-chat">
            <div class="fb-comments" data-href="http://<%=Request.Url.Host %><%= Request.RawUrl %>" data-width="650"></div>
        </div>
        
        <div class="7372362"></div>

    </div>
</asp:Content>

