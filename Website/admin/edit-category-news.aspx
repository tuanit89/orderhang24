<%@ Page Title="Cập nhật danh mục tin" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-category-news.aspx.cs" Inherits="Website.admin.edit_category_news" %>
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
            <% if (IsEdit)
               { %>Cập nhật nhóm tin tức dịch vụ<% }
               else
               {
                %>
                   Thêm mới nhóm tin - dịch vụ
                <%
               } %>
            
        </div>
        <div class="toolbar-action">
            <ul>
                <li><asp:LinkButton ID="LinkButton1" runat="server" onclick="Unnamed1_Click"><span class="toolbar-update-back"></span>Lưu và quay lại</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" onclick="Unnamed1_Click2"><span class="toolbar-insert"></span>Lưu và thêm mới</asp:LinkButton>
                  <a><span class="toolbar-support"></span>Hướng dẫn </a></li>
            </ul>
        </div>
    </div>
    <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">Danh mục nhóm</td>
                <td class="tblSkinValueColumn">
                    <asp:DropDownList runat="server" ID="drpCateType" Width="200px" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên nhóm tin</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtCategoryname" Width="100%" AutoCompleteType="None"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Sắp xếp</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtSort" Width="100px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Phần mô tả</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtMota" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
             <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Phần mô tả SEO</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtTukhoa" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tags</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtTags" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
