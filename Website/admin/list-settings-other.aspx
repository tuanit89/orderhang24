<%@ Page Title="Danh sách cấu hình thiết lập" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="list-settings-other.aspx.cs" Inherits="Website.admin.list_settings_other" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="navi-action">
        <div class="clear"></div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách cấu hình
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="edit-settings-other.aspx">
                        <span class="toolbar-insert"></span>
                        Thêm mới
                    </a>
                 </li>
            </ul>
        </div>
    </div>
    <asp:GridView runat="server" CssClass="tblList" ID="grvUser" DataKeyNames="Key"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting" 
         onrowediting="grvUser_RowEditing" AllowPaging="True" PageSize="10" 
         onselectedindexchanging="grvUser_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <ItemTemplate>
                   <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Mã thiết lập" DataField="Key"/>
            <asp:BoundField HeaderText="Giá trị" DataField="Value" HtmlEncode="False"/>
            <asp:BoundField HeaderText="Mô tả" DataField="Description"/>
            <asp:TemplateField HeaderText="Thao tác">
               <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                        OnClientClick="javascript:{ return confirm('Bạn chắc muốn xóa chứ?');}" />
                    <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Edit" CommandArgument='<%# Eval("Key") %>'
                        ImageUrl="/admin/images/edit.gif" />
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
