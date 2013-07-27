<%@ Page Title="Quản lý khuyến mại" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="promotion-product.aspx.cs" Inherits="Website.admin.promotion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="toolbar clearfix">
        <div class="toolbar-title">
            <%= !IsEdit?"Thêm mới ":"Sửa " %> khuyến mại
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="InsertAndBack" onclick="InsertAndBack_Click">
                        <span class="toolbar-update-back"></span>
                        Lưu
                    </asp:LinkButton>
                 </li>
            </ul>
        </div>
    </div>
     <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Giá trị khuyến mại</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtValuePromote" Width="99%"/>
                </td>
            </tr>
        </tbody>
    </table>
    <h3 style="margin-top: 20px;padding-top:5px;border-top:2px solid #6381C0;">Danh sách giá trị khuyến mại</h3>
        <asp:GridView runat="server" CssClass="tblList" ID="grvPromote" DataKeyNames="id"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting" 
         onrowediting="grvUser_RowEditing" AllowPaging="True" PageSize="10" 
         onselectedindexchanging="grvUser_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <ItemTemplate>
                   <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Giá trị" DataField="PromoteValue"/>
            <asp:TemplateField HeaderText="Thao tác">
               <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                        OnClientClick="javascript:{ return confirm('Bạn chắc muốn xóa chứ?');}" />
                    <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Edit" CommandArgument='<%# Eval("id") %>'
                        ImageUrl="/admin/images/edit.gif" />
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
