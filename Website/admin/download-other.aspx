<%@ Page Title="Công cụ tải mẫu file" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="download-other.aspx.cs" Inherits="Website.admin.download_other" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="toolbar clearfix">
        <div class="toolbar-title">
            Công cụ tải mẫu file
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="InsertAndNew" OnClick="InsertAndNew_Click">
                        <span class="toolbar-update-insert"></span>
                        Tải mẫu lên
                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
    <div style="color: red;padding: 3px 0;font-weight: bold;font-size: 14px;text-align: center"><asp:Label ID="lblThongBao" runat="server"></asp:Label></div>
     <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Chọn file
                </td>
                <td class="tblSkinValueColumn">
                    <asp:FileUpload runat="server" ID="fUpload" Width="99%" />
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
