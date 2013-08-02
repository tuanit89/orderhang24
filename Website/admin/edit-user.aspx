<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-user.aspx.cs" Inherits="Website.admin.edit_user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="navi-action">
        <asp:Literal runat="server" EnableViewState="False" ID="ltrThongbao" />
        <div class="clear">
        </div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
          <% if(IsEdit){%>
                    Cập nhật thông tin người dùng<% }else{%>
                    Thêm mới người dùng<%} %>
        </div>
        <div class="toolbar-action">
            <ul>
                <li><asp:LinkButton ID="LinkButton1" runat="server" onclick="Unnamed1_Click"><span class="toolbar-update-back"></span>Lưu và quay lại</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" onclick="Unnamed2_Click"><span class="toolbar-insert"></span>Lưu và thêm mới</asp:LinkButton>
                  <a><span class="toolbar-support"></span>Hướng dẫn </a></li>
            </ul>
        </div>
    </div>
    <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Họ tên</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtFullname" Width="130px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên đăng nhập
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtUsername" Width="130px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Mật khẩu
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" Width="130px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Quản trị người dùng?
                </td>
                <td class="tblSkinValueColumn">
                    <asp:CheckBox runat="server" ID="checkAdmin"/>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
