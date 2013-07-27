<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit-slideshow.aspx.cs" Inherits="Website.admin.edit_slideshow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .Images {
            max-width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Cập nhật thông tin slide
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton ID="Link_Save" runat="server" onclick="Link_Save_Click">
                        <span class="toolbar-update-back"></span>
                        Lưu
                    </asp:LinkButton>
                    <asp:LinkButton ID="Link_SaveAndBack" runat="server" 
                        onclick="Link_SaveAndBack_Click">
                         <span class="toolbar-update-back"></span>
                        lưu và trở lại
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="return false;">
                        <span class="toolbar-support"></span>
                        Hướng dẫn
                    </asp:LinkButton>
                 </li>
            </ul>
        </div>
    </div>
    <asp:Label ID="LB_Messenger" runat="server" Text=""></asp:Label>
    <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr>
                <td class="tblSkinHeaderColumn" width="150px">
                    Tên ảnh
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox ID="TB_Name" runat="server" MaxLength="100" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Ảnh
                </td>
                <td class="tblSkinValueColumn">
                    <div style="padding: 4px 0">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/no_pic.png" BorderStyle="None"
                            BorderWidth="0px" CssClass="Images" Width="100" />
                    </div>
                    <asp:FileUpload ID="Upload_Images" runat="server" />
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Alt image
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox ID="TB_Alt" runat="server" MaxLength="200" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Link
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox ID="TB_Link" runat="server" MaxLength="200" Width="300px"></asp:TextBox>
                </td>
            </tr>
        </tbody>
    </table>
    <div>
        <input type="hidden" runat="server" id="HD_ID" value="0" />
        <input type="hidden" runat="server" id="HD_Image" value="" />
    </div>
</asp:Content>
