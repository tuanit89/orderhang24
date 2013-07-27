<%@ Page Title="Admin panel - Sửa thông tin cá nhân" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="update-profile-user.aspx.cs" Inherits="Website.admin.update_profile" %>
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
          Cập nhật thông tin cá nhân</div>
        <div class="toolbar-action">
            <ul>
                <li><asp:LinkButton runat="server" onclick="Unnamed1_Click"><span class="toolbar-update-back"></span>Lưu và quay lại</asp:LinkButton>
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
                    <asp:TextBox runat="server" ID="Fullname" Width="300px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên đăng nhập
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="Username" Width="200px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Mật khẩu
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="Password" TextMode="Password" Width="130px"/>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
