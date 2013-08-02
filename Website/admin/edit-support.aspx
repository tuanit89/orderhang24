<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-support.aspx.cs" Inherits="Website.admin.edit_support" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="toolbar clearfix">
        <div class="toolbar-title">
            <%= !IsEdit?"Thêm mới":"Sửa nhân viên hỗ trợ " %>
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="InsertAndNew" onclick="InsertAndNew_Click">
                        <span class="toolbar-update-insert"></span>
                        Lưu và Thêm mới
                    </asp:LinkButton>
                    <asp:LinkButton runat="server" ID="InsertAndBack" onclick="InsertAndBack_Click">
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
                    Tên nhân viên hỗ trợ</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtSupportName" Width="99%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Số điện thoại hỗ trợ</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtSDT" Width="99%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Nick Yahoo</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtYahoo" Width="99%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Nick Skype</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtSkype" Width="99%"/>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
