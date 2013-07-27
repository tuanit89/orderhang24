<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Import Namespace="Models.StringHelper" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="order">
        <div class="order-news fl">
            <h2 class="title cufont">
                Galaxy Order
            </h2>
            <div class="summary cufont">
                Làm sao để order hàng Quảng Châu nhanh gọn ở Việt Nam chỉ với cú click chuột mà
                sản phẩm vẫn tốt nhất ?
            </div>
            <div class="list-item">
                <% for (int i = 0; i < 4; i++)
                   {%>
                <div class="item">
                    <a href="#">#1 Uy tín về dịch vụ order hàng Quảng Châu</a>
                </div>
                <%} %>
            </div>
            <div class="note">
                will not make the same mistakes that you did
                <br />
                I will not let myself<br />
                Cause my heart so much misery
            </div>
        </div>
        <div class="view-rate fr">
            <div class="view">
                <div class="show-view fl">
                    <h3 class="title">
                        Khách hàng review
                    </h3>
                    <div class="view-detail">
                        Sản phẩm này tốt Sản phẩm này tốt Sản phẩm này tốt Sản phẩm này tốt                        
                    </div>
                    <div class="user">
                        <a href="#">Hoàng Thị Thu</a>
                    </div>
                </div>
                <div class="basket-dv fl">
                    <div class="money">
                        <img alt="" src="/Content/images/unit-money.png" />
                        <div class="price">
                            <p>TỶ GIÁ</p>
                            <span>360 vnđ</span>
                        </div>
                    </div>
                    <div class="download">
                        <img alt="" src="/Content/images/img-basket.png" />
                        <div class="dowload-number">
                            <p>Download mẫu order</p>
                            <span>Số lượt tải : 1667</span>
                        </div>
                    </div>
                    <% if (Model.Supports != null && Model.Supports.Count > 0)
                       { %>
                            <div class="support">
                                <p class="support-title">Hỗ trợ online</p>
                                <% for (var i = 0; i < Model.Supports.Count; i++)
                                   { %>
                                        <div class="yahoo<%= i==0?" yahoo1":"" %>">
                                            <a href="ymsgr:sendIM?<%= Model.Supports[i].Yahoo %>" title="Liên lạc IM với <%= Model.Supports[i].Name %>">
                                                <div class="icon">
                                                    <p><%= Model.Supports[i].Name %></p>
                                                </div>
                                            </a>
                                            <p class="phone">ĐT : <%= Model.Supports[i].Phone %></p>
                                        </div>
                                   <%} %>
                                <div class="clear"></div>
                            </div>
                    <% } %>
                </div>
                <div class="clear">
                </div>
            </div>
            <!-- END VIEW -->
            <% if(Model.ExpNews!=null && Model.ExpNews.Count>0)
                { %>
                    <div class="rate">
                        <%  for (int i = 0; i < Model.ExpNews.Count; i++)
                            { %>
                                <div class="item">
                                    <h3 class="title"><%= Model.ExpNews[i].Title %></h3>
                                    <div class="detail"><%= Model.ExpNews[i].Description.CutWordByLength(166) %></div>
                                    <div class="star-viewmore">
                                        <div class="star"></div>
                                        <span>84 votes</span>
                                        <div class="view-more"><a href="<%= Model.ExpNews[i].Link %>">Xem tiếp...</a> </div>
                                        <div class="clear"></div>
                                    </div>
                                </div>
                            <% } %>
                    </div>
                <%  }    
            %>
            
            <!-- END RATE -->
        </div>
        <div class="clear"></div>
        <!-- END OORDER-RATE -->
        <div class="list-category">
            <%
                for (int i = 0; i < 3; i++)
                {%>
            <div class="item item-<%=i %>">
                <div class="detail">
                    <p class="title">Autumn</p>
                    <p class="name">Bed & Bath</p>
                    <p class="title">Event</p>
                </div>
            </div>
            <% }    
            %>
            <div class="clear"></div>
        </div>
        <!-- END LIST CATEGORY -->
        <div class="list-images">
            <a href="#">
                <img alt="" src="/Content/images/list-img1.png" /></a>
            <a href="#">
                <img alt="" src="/Content/images/list-img1.png" /></a>
            <a href="#">
                <img alt="" src="/Content/images/list-img1.png" /></a>
            <a href="#" class="last">
                <img alt="" src="/Content/images/list-img1.png" /></a>
            <div class="clear"></div>
        </div>
    </div>
</asp:Content>
