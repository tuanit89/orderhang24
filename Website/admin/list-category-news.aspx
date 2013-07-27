<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="list-category-news.aspx.cs" Inherits="Website.admin.list_category_news" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="navi-action">
        <div class="clear"></div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách nhóm tin tức
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="edit-category-news.aspx">
                        <span class="toolbar-insert"></span>
                        Thêm mới
                    </a>
                    <asp:LinkButton runat="server" ID="btnXoa">
                        <span class="toolbar-delete"></span>
                        Xóa
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
            Chọn nhóm danh mục
            <asp:DropDownList runat="server" ID="drpCateType" OnSelectedIndexChanged="Change_Selected_CateType" AutoPostBack="True">
                <asp:ListItem Value="all" Text="[- Tất cả -]" Selected="True" />
                
            </asp:DropDownList>
        </div>
    <asp:GridView runat="server" CssClass="tblList" ID="grvUser" DataKeyNames="id"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting" onrowediting="grvUser_RowEditing" >
        <Columns>
            <asp:TemplateField HeaderText="Chọn">
                <HeaderTemplate><input type="checkbox"/></HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox runat="server" ID="chkGrid"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên nhóm tin" DataField="name"/>
            <asp:BoundField HeaderText="Sắp xếp" DataField="Sort"/>
            <asp:BoundField HeaderText="Mô tả" DataField="Description"/>
            <asp:BoundField HeaderText="Mô tả SEO" DataField="MetaDescription"/>
            <asp:TemplateField HeaderText="Thao tác">
               <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                        OnClientClick="javascript:{ return confirm('Xóa nhóm này, các bản tin trong nhóm sẽ bị xóa? Bạn chắc chứ?');}" />
                    <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Edit" CommandArgument='<%# Eval("id") %>'
                        ImageUrl="/admin/images/edit.gif" />
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
</asp:Content>
