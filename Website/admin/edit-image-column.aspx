<%@ Page Title="Cập nhật danh mục khối hình ảnh" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-image-column.aspx.cs" Inherits="Website.admin.edit_image_column" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="navi-action" style="color: red;font-size: 14px;text-align: center;font-weight: bold">
        <asp:Literal runat="server" EnableViewState="False" ID="ltrThongbao" />
        </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            <% if (IsEdit)
               { %>Cập nhật <% }
               else
               {
                %>
                   Thêm mới
                <%
               } %>
               khối hình ảnh
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
                    <asp:DropDownList runat="server" ID="drpCateType" Width="200px">
                        <Items>
                            <asp:ListItem Value="top3" Text="3 cột"></asp:ListItem>
                            <asp:ListItem Value="top4" Text="4 cột"></asp:ListItem>
                        </Items>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên cột tin</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtColumnName" Width="100%" AutoCompleteType="None"/>
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
                    Tên 1</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtname1" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
             <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên 2</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtname2" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
             <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên 3</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtname3" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
             <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Link</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtlink" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
             <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    File ảnh</td>
                <td class="tblSkinValueColumn">
                    <asp:FileUpload runat="server" ID="txtimage" />
                </td>
            </tr>
             <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Image caption</td>
                <td class="tblSkinValueColumn"> 
                    <asp:Image runat="server" Width="200px" ID="img"/>
                    <asp:TextBox runat="server" ID="txtalt" Width="100%" TextMode="MultiLine"/>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
