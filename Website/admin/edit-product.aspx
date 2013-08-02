<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-product.aspx.cs" Inherits="Website.admin.edit_product" %>
<%@ Register TagPrefix="ck" Namespace="CKEditor.NET" Assembly="CKEditor.NET, Version=3.6.2.0, Culture=neutral, PublicKeyToken=e379cdf2f8354999" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title"><%= IsEdit?"Thêm mới":"Cập nhật" %> sản phẩm</div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="btnLuuVaThemmoi" onclick="btnLuuVaThemmoi_Click">
                        <span class="toolbar-update-insert"></span>
                        Lưu và thêm mới
                    </asp:LinkButton>
                    <asp:LinkButton runat="server" ID="LinkButton1" onclick="LinkButton1_Click">
                        <span class="toolbar-update-back"></span>
                        Lưu và quay lại
                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
    <table width="100%" class="tblDetailSkin">
                <tbody><tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn" width="150px">
                        <span class="notifi-requited">(*)</span> Danh mục sản phẩm
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:DropDownList runat="server" ID="lstCate" DataTextField="Name" DataValueField="Id"/>
                    </td>
                </tr>
                <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        <span class="notifi-requited">(*)</span> Tên sản phẩm
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:TextBox runat="server" ID="txtProductName" Width="98%"  CssClass="mota-seo" data-length="70"/>
                    </td>
                </tr>
             <%--   <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        <span class="notifi-requited">(*)</span> Model
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:TextBox runat="server" ID="txtModel" Width="98%"/>
                    </td>
                </tr>--%>
                <%--<tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Hãng sản xuất
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:DropDownList runat="server" ID="drpSupplier" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
                    </td>
                </tr>--%>
                <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Mô tả
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:TextBox runat="server" ID="txtDescription" Width="98%" TextMode="MultiLine" Height="200px" CssClass="mota-seo" data-length="165"/>
                    </td>
                </tr>
                <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Tùy chọn hiển thị
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:CheckBox runat="server" ID="chkSetHot" Text="Sản phẩm hot"/>
                        <asp:CheckBox runat="server" ID="chkSetMost" Text="Sản phẩm được quan tâm"/>
                    </td>
                </tr>
                <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Chi tiết
                    </td>
                    <td class="tblSkinValueColumn">
                        <ck:CKEditorControl runat="server" ID="txtContent" BasePath="/Content/ckeditor/" FilebrowserBrowseUrl="/Content/ckfinder/ckfinder.html" Height="400" />
                        <div style="clear: both"></div>
                    </td>
                </tr>
                <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Ảnh đại diện
                    </td>
                    <td class="tblSkinValueColumn">
                        <div>
                            <asp:Literal runat="server" ID="img"></asp:Literal>
                            <asp:Button runat="server" ID="btnXoaAnh" Text="Xóa ảnh" 
                                onclick="btnXoaAnh_Click"/>
                        </div>
                        <asp:FileUpload runat="server" ID="fUpload"/>
                        
                    </td>
                </tr>
                 <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Alt ảnh
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:TextBox runat="server" ID="txtAlt" Width="90%"></asp:TextBox>
                    </td>
                </tr>
                <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Giá
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:TextBox runat="server" ID="txtPrice"></asp:TextBox>
                    </td>
                </tr>
                <tr class="tblSkinRow">
                    <td class="tblSkinHeaderColumn">
                        Tags
                    </td>
                    <td class="tblSkinValueColumn">
                        <asp:TextBox runat="server" Width="99%" ID="txtTags" Height="100px"/>
                    </td>
                </tr>
            </tbody></table>
            
            <h3 style="margin-top: 20px;padding-top:5px;border-top:2px solid #6381C0;">Các thuộc tính</h3>
             <asp:Table width="100%" class="tblDetailSkin" runat="server" id="tblProperty"></asp:Table>
</asp:Content>
