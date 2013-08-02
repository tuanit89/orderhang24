<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-news.aspx.cs" Inherits="Website.admin.edit_news" %>
<%@ Register Namespace="CKEditor.NET" Assembly="CKEditor.NET" TagPrefix="ck" %>
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
               { %>Cập nhật bản tin<% }
               else
               {
                %>
                   Thêm mới bản tin
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
                <td class="tblSkinHeaderColumn">
                    Chọn nhóm tin</td>
                <td class="tblSkinValueColumn">
                    <asp:DropDownList runat="server" ID="drpNhomTin" Width="400px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên tin</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtTenTin" Width="98%" CssClass="mota-seo" data-length="70"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Mô tả</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtdesc" Width="98%" TextMode="MultiLine"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Hình ảnh</td>
                <td class="tblSkinValueColumn">
                    <img src="<%= Images %>" style="float: left;width:200px"/>
                    <p style="float: right">
                        <asp:FileUpload runat="server" ID="upHinhanh"/>
                    </p>
                    
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Nội dung</td>
                <td class="tblSkinValueColumn">
                    <ck:CKEditorControl runat="server" ID="txtContent" BasePath="/Content/ckeditor/" FilebrowserBrowseUrl="/Content/ckfinder/ckfinder.html" Height="400" />
                    <div style="clear: both"></div>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Hiển thị trên trang chủ?</td>
                <td class="tblSkinValueColumn">
                    <asp:CheckBox runat="server" ID="chkAction" Width="100%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Alt Image</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtAlt" Width="100%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Mô tả dành cho seo</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtMotaSeo" Width="98%" TextMode="MultiLine" CssClass="mota-seo" data-length="165"/>
                    <br/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Sắp xếp</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtSort" Width="200px"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tag</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtTags" Width="98%" TextMode="MultiLine"/>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
