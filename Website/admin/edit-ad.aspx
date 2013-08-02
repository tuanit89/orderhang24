<%@ Page Title="Cập nhật quảng cáo" Language="C#" MasterPageFile="~/admin/Admin.Master"
    AutoEventWireup="true" CodeBehind="edit-ad.aspx.cs" Inherits="Website.admin.edit_ad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            <%= !IsEdit?"Thêm mới ":"Sửa " %>
            quảng cáo
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="InsertAndNew" OnClick="InsertAndNew_Click">
                        <span class="toolbar-update-insert"></span>
                        Lưu và Thêm mới
                    </asp:LinkButton>
                    <asp:LinkButton runat="server" ID="InsertAndBack" OnClick="InsertAndBack_Click">
                        <span class="toolbar-update-back"></span>
                        Lưu và trở lại
                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
    <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên quảng cáo
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtAdName" Width="99%" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Nơi hiển thị
                </td>
                <td class="tblSkinValueColumn">
                    <asp:DropDownList ID="drpLocation" runat="server">
                        <asp:ListItem Value="ad" Text="Quảng cáo" />
                        <asp:ListItem Value="partner" Text="Đối tác" />
                        <asp:ListItem Value="bodyhome" Text="Thân trang chủ" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Mô tả
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtDes" Width="99%" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Hình ảnh
                </td>
                <td class="tblSkinValueColumn">
                    <asp:Literal runat="server" ID="ltrHinhAnh" />
                    <asp:FileUpload runat="server" ID="fUpload" Width="99%" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Đường liên kết
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtLink" Width="99%" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Sắp xếp
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtSort" Width="200px" />
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
