<%@ Page Title="Nhận xét khách hàng" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-reviews.aspx.cs" Inherits="Website.admin.edit_reviews" %>
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
                    Tên khách hàng
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtCustomerName" Width="99%" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Nhận xét
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtReviews" Width="99%" TextMode="MultiLine" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Điện thoại
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtDienThoai" Width="99%"  />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Địa chỉ
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtDiaChi" Width="99%" TextMode="MultiLine" />
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
