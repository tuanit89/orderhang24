<%@ Page Title="Quản lý cột hình ảnh" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="list-image-column.aspx.cs" Inherits="Website.admin.list_image_column" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="navi-action">
        <div class="clear"></div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Quản lý cột hình ảnh
        </div>
         <div class="toolbar-action">
            <ul>
                <li>
                   <a href="edit-image-column.aspx">
                        <span class="toolbar-insert"></span>
                        Thêm mới
                    </a>
                 </li>
            </ul>
        </div>
    </div>
     <div class="div-search clearfix">
        <div style="float: left">
            Chọn kiểu khối
            <asp:DropDownList runat="server" ID="drpKhoi" AutoPostBack="True" 
                onselectedindexchanged="drpKhuvuc_SelectedIndexChanged">
                <asp:ListItem Text="[ Mời chọn ]" Value="0" Selected="True"/>
                <asp:ListItem Text="Top 3" Value="top3" />
                <asp:ListItem Text="Top 4" Value="top4" />
            </asp:DropDownList>
        </div>
    </div>
    <asp:GridView runat="server" CssClass="tblList" ID="grvUser" DataKeyNames="id"
        AutoGenerateColumns="False" onrowediting="grvUser_RowEditing" 
        onrowdeleting="grvUser_RowDeleting">
        <Columns>
            <asp:BoundField HeaderText="Tên khối" DataField="ImageColumnName"/>
            <asp:BoundField HeaderText="Tên 1" DataField="Name1"/>
            <asp:BoundField HeaderText="Tên 2" DataField="Name2"/>
            <asp:BoundField HeaderText="Tên 3" DataField="Name3"/>
            <asp:BoundField HeaderText="Link" DataField="Link"/>
             <asp:TemplateField HeaderText="Thao tác">
               <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                        OnClientClick="javascript:{ return confirm('Bạn có muốn xóa không?');}" />
                    <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Edit" CommandArgument='<%# Eval("id") %>'
                        ImageUrl="/admin/images/edit.gif" />
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
</asp:Content>
