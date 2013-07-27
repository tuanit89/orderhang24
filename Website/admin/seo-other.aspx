<%@ Page Title="" Language="C#" MasterPageFile="~/admin/UniAdmin.Master" AutoEventWireup="true"
    CodeBehind="seo-other.aspx.cs" Inherits="dongphucdangcap.com.admin.seo_other"
    ValidateRequest="false" %>

<%@ Register TagPrefix="ck" Namespace="CKEditor.NET" Assembly="CKEditor.NET, Version=3.6.2.0, Culture=neutral, PublicKeyToken=e379cdf2f8354999" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="navi-action">
        <div class="clear">
        </div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Cập nhật thông tin đề mục seo
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="btnAc" OnClick="btnAc_Click">
                        <span class="toolbar-update"></span>
                        Lưu
                    </asp:LinkButton>
                    <a><span class="toolbar-support"></span>Hướng dẫn </a></li>
            </ul>
        </div>
    </div>
    <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Nội dung
                </td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox ID="txtContent" TextMode="MultiLine" Width="100%" Height="400"  runat="server"/>
                </td>
            </tr>
        </tbody>
    </table>
    <asp:HiddenField runat="server" ID="drpv" />
</asp:Content>
