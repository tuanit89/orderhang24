<%@ Page Title="Admin panel - Quản trị vùng" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="True" CodeBehind="edit-template-other.aspx.cs" Inherits="Website.admin.edit_template" validateRequest="false" %>
<%@ Register TagPrefix="ck" Namespace="CKEditor.NET" Assembly="CKEditor.NET, Version=3.6.2.0, Culture=neutral, PublicKeyToken=e379cdf2f8354999" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="navi-action">
        <div class="clear"></div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Cập nhật thông tin vùng website
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="btnAc" onclick="btnAc_Click">
                        <span class="toolbar-update"></span>
                        Lưu
                    </asp:LinkButton>
                    <a>
                        <span class="toolbar-support"></span>
                        Hướng dẫn
                    </a>
                 </li>
            </ul>
        </div>
    </div>
    <div class="div-search clearfix">
        <div style="float: left">
            Chọn khu vực cần sửa
            <asp:DropDownList runat="server" ID="drpKhuvuc" AutoPostBack="True" 
                onselectedindexchanged="drpKhuvuc_SelectedIndexChanged">
                <asp:ListItem Text="[ Mời chọn ]" Value="0" Selected="True"/>
                <asp:ListItem Text="Nội dung chân trang" Value="1" />
                <asp:ListItem Text="Nội dung trang liên hệ" Value="2" />
                <asp:ListItem Text="Nội dung địa chỉ cửa hàng" Value="3" />
                
            </asp:DropDownList>
        </div>
    </div>
    <asp:Panel runat="server" ID="panelSupport">
        <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Nội dung    
                </td>
                <td class="tblSkinValueColumn">
                   <ck:CKEditorControl runat="server" BasePath="/Content/ckeditor" ID="txtContent" FilebrowserBrowseUrl="/Content/ckfinder/ckfinder.html"
                                        Height="400px" Width="99%"/>
                </td>
            </tr>
        </tbody>
    </table>
  </asp:Panel>
</asp:Content>
