<%@ Page Title="Cập nhật giá trị cấu hình site" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-settings-other.aspx.cs" Inherits="Website.admin.edit_settings_other" %>
<%@ Register Namespace="CKEditor.NET" Assembly="CKEditor.NET" TagPrefix="ck" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #file-info{ padding: 5px;}
    </style>
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
               { %>Cập nhật<% }
               else
               {
                %>
                   Thêm mới
                <%
               } %> thiết lập</div>
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
                <td class="tblSkinHeaderColumn">
                    Mã cài đặt</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtKey" Width="98%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Giá trị</td>
                <td class="tblSkinValueColumn">
                     <ck:CKEditorControl runat="server" ID="txtValue" BasePath="/Content/ckeditor/" FilebrowserBrowseUrl="/Content/ckfinder/ckfinder.html" Height="300" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Mô tả sơ lược</td>
                <td class="tblSkinValueColumn">
                    <div style="clear: both">
                    <asp:TextBox runat="server" ID="txtDescripton" Width="98%" TextMode="MultiLine"/>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
