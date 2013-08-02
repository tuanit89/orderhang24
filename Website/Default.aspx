<%@ Page Title="Order hàng Quảng Châu | Order 24 | Order hàng Bắc Kinh" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Import Namespace="Models.StringHelper" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="order">
        <% if(DichvuCategory!=null)
           { %>
                <div class="order-news fl">
                    <h2 class="title cufont">
                    <%= DichvuCategory.Headline %>
                    </h2>
                    <strong class="title" style="display: block"><%= DichvuCategory.BelowHead %></strong>
                    <div class="summary">
                        <%=DichvuCategory.Note %>
                    </div>
                    <div class="list-item">
                        <% if (DichvuCategory.ListNewsByType() != null && DichvuCategory.ListNewsByType().Count > 0)
                           { %>
                                <% foreach (var item in DichvuCategory.ListNewsByType())
                                   {%>
                                    <div class="item">
                                        <a href="<%= item.Link %>"><%= item.Title %></a>
                                    </div>
                                <% } %>
                        <% } %>
                    </div>
                    <div class="note">
                        <%= DichvuCategory.NoteBelow %>
                    </div>
            </div>
        <% } %>
        <div class="view-rate fr">
            <div class="view">
                <div class="show-view fl">
                    <h3 class="title">
                        Khách hàng review
                    </h3>
                    <div class="view-detail">
                        <%= Review.CustomerComment %>                        
                    </div>
                    <div class="user">
                        <a><%= Review.CustomerName %></a>
                    </div>
                </div>
                <div class="basket-dv fl">
                    <div class="money">
                        <img alt="" src="/Content/images/unit-money.png" />
                        <div class="price">
                            <p>TỶ GIÁ</p>
                            <span><%= Models.DataAccess.SettingImpl.Instance.GetByKey("tigia").Value %></span>
                        </div>
                    </div>
                    <div class="download">
                        <img alt="" src="/Content/images/img-basket.png" />
                        <div class="dowload-number">
                            <p><a href="/download.aspx" rel="nofollow">Download mẫu order</a></p>
                            <span style="color: #313b47">Số lượt tải : 1667</span>
                        </div>
                    </div>
                    <% if (Supports != null && Supports.Count > 0)
                       { %>
                            <div class="support">
                                <p class="support-title">Hỗ trợ online</p>
                                <% for (var i = 0; i < Supports.Count; i++)
                                   { %>
                                        <div class="yahoo<%= i==0?" yahoo1":"" %>">
                                            <a href="ymsgr:sendIM?<%= Supports[i].Yahoo %>" title="Liên lạc IM với <%= Supports[i].Name %>">
                                                <div class="icon">
                                                    <p><%= Supports[i].Name %></p>
                                                </div>
                                            </a>
                                            <p class="phone">ĐT : <%= Supports[i].Phone %></p>
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
            <% if (Newses != null && Newses.Count > 0)
                { %>
                    <div class="rate">
                        <%  for (int i = 0; i < Newses.Count; i++)
                            { %>
                                <div class="item">
                                    <h3 class="title"><%= Newses[i].Title %></h3>
                                    <div class="detail"><%= Newses[i].Description.CutWordByLength(166) %></div>
                                    <div class="star-viewmore">
                                        <div class="star"></div>
                                        <span>84 votes</span>
                                        <div class="view-more"><a href="<%= Newses[i].Link %>">Xem tiếp...</a> </div>
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
                for (int i = 0; i < LisTop3.Count; i++)
                {
                    if (i == 1)
                    { %>
            <div class="item-spec">
                <% }    
                %>
                <div class="item item-<%=i %>">
                    <div class="detail">
                        <%= "<p class=\"title\">"+(!string.IsNullOrEmpty(LisTop3[i].Name1)?LisTop3[i].Name1:"")+"</p>" %>
                        <%= "<p class=\"name\"><a href=\""+LisTop3[i].Link+"\">"+(!string.IsNullOrEmpty(LisTop3[i].Name2)?LisTop3[i].Name2:"")+"</a></p>"%>
                        <%= "<p class=\"title\">"+(!string.IsNullOrEmpty(LisTop3[i].Name3)?LisTop3[i].Name3:"")+"</p>" %>
                    </div>
                </div>
                <%if (i == 2)
                  { %>
            </div>
            <div class="clear"></div>
            <%}
                }    
            %>
            <div class="clear">
            </div>
        </div>
        <!-- END LIST CATEGORY -->
        <div class="list-images">
            <%
                for (int i = 0; i < ListTop4.Count; i++)
                {
                    string imgClass = "";
                    if (i == 2) {
                        imgClass = "item-3";
                    }
                    else if (i == 3) {
                        imgClass = "last";
                    }
                 %>
                  <a class="<%=imgClass %>" href="<%= ListTop4[i].Link %>"><img alt="<%= ListTop4[i].Alternate %>" src="/Images/columns/<%= ListTop4[i].Image %>" /></a>    
               <% }
            %>
                          
            <div class="clear"></div>
        </div>
    </div>
</asp:Content>
