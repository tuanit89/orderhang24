<%@ Page Title="Liên hệ - Orderhang24.com" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Website.contact" %>
<%@ Register TagPrefix="usc" TagName="menu" Src="~/Controls/sidebar.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!-- Category-->
    <usc:menu runat="server" />
    <div class="product-container-items">
       <h2 class="breadcump">
            <span>Bạn đang ở: </span>
            <%= BreadCump %>
        </h2>
        
        <div class="product-content-item clearfix">
            <div class="contact-us">
               <%= ContactString %>
            </div>
        </div>
        
        <!--feedback-->
        <form class="feedback" method="GET" action="">
            <h3 class="h3-desc">Gửi liên hệ</h3>
    
            <div class="input-row">
                <span class="row-label">Họ tên</span>
                <input type="text" class="inputlh" id="txtFullName" />
            </div>
           <div class="input-row">
                <span class="row-label">Địa chỉ email</span>
                <input type="text" class="inputlh" id="txtEmail"/>
            </div>
            <div class="input-row">
                <span class="row-label">Điện thoại</span>
                <input type="text" class="inputlh" id="txtPhone" />
            </div>
            <div class="input-row">
                <span class="row-label">Tiêu đề</span>
                <input type="text" class="inputlh" id="txtSubject" />
            </div>
            <div class="input-row clearfix">
                <span class="row-label" style="float: left">Nội dung</span>
                <textarea type="text" class="inputlh-area" id="txtMessage" cols="6"></textarea>
            </div>
            <div class="input-row" style="text-align: right;padding-right: 40px">
                <a href="" id="btnClick">
                    <img src="/Content/images/senmail.png" />
                </a>
            </div>
        </form>
        <script type="text/javascript">
            $(".feedback").on("submit", SendContact);
            $("#btnClick").on("click", SendContact);

            function SendContact() {
                if ($("#txtFullName").val().length == 0 || $("#txtEmail").val().length == 0 || $("#txtSubject").val().length == 0 || $("#txtMessage").val().length == 0) {
                    alert("Bạn cần nhập tên, email, tiêu đề và nội dung để chúng tôi có thể phản hồi lại hồi âm của bạn. Cảm ơn!");
                    return false;
                }
                var fullname = $("#txtFullName").val();
                var email = $("#txtEmail").val();
                var subject = $("#txtSubject").val();
                var mesage = $("#txtMessage").val();
                var phone = $("#txtPhone").val();
                $.ajax({
                    type: "POST",
                    data: { fullname: fullname, email: email, subject: subject, message: mesage, phone: phone },
                    url: "/lien-he.aspx",
                    success: function (d) {
                        if (d > 0) {
                            alert("Đã gửi! Cảm ơn bạn đã liên hệ với chúng tôi!");
                            $(".input-row input[text],.input-row textarea").val("");
                            setTimeout(function () {
                                window.location.href = "/";
                            }, 2000);
                        }
                    }
                });
                return false;
            }
        </script>
    </div>
</asp:Content>
