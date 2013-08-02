<%@ Page Title="Thêm hoặc sửa danh mục" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="edit-category-product.aspx.cs" Inherits="Website.admin.edit_category_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            <%= (!IsEdit?"Thêm mới":"Sửa nhóm")+" danh mục" %>
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="InsertAndNew" onclick="InsertAndNew_Click">
                        <span class="toolbar-insert"></span>
                        Lưu và Thêm mới
                    </asp:LinkButton>
                    <asp:LinkButton runat="server" ID="InsertAndBack" onclick="InsertAndBack_Click">
                        <span class="toolbar-delete"></span>
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
                    Kiểu nhóm</td>
                <td class="tblSkinValueColumn">
                    <asp:DropDownList runat="server" ID="drpCate" Width="300" DataTextField="Name" DataValueField="Id"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên nhóm sản phẩm</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtCategoryname" Width="99%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Mô tả</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtDesc" Width="99%" Height="100px" TextMode="MultiLine"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Phần mô tả seo</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtMota" Width="99%" TextMode="MultiLine"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Số thứ tự</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtSort" Width="200"/>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
