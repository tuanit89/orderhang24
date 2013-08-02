<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="list-slideshow.aspx.cs" Inherits="Website.admin.list_slideshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách ảnh slideshow
        </div>
        <div class="toolbar-action">
            <ul>
                <li><a href="edit-slideshow.aspx"><span class="toolbar-insert"></span>Thêm mới </a><a>
                    <span class="toolbar-support"></span>Hướng dẫn </a></li>
            </ul>
        </div>
    </div>
    <%--<div class="div-search clearfix">
        <div style="float: left">
            Chọn danh mục
            <asp:DropDownList ID="drpCate" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_ProductType_SelectedIndexChanged"
                Width="200px">
            </asp:DropDownList>
        </div>
        <div style="float: right">
            <asp:DropDownList runat="server" ID="drpPageNum" AutoPostBack="True" 
                onselectedindexchanged="drpPageNum_SelectedIndexChanged" />
        </div>
    </div>--%>
    <asp:GridView ID="GV_Album" DataKeyNames="id" runat="server" AutoGenerateColumns="False"
        PageSize="20" HeaderStyle-Font-Size="12px" RowStyle-Font-Size="12px" EnableTheming="False"
        EmptyDataText="Không tìm thấy bản ghi nào" CssClass="tblList" GridLines="Vertical"
        Width="100%" AllowPaging="True" OnPageIndexChanging="GV_Album_PageIndexChanging"
        OnRowDeleting="GV_Album_RowDeleting" OnRowEditing="GV_Album_RowEditing">
        <PagerStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        <HeaderStyle HorizontalAlign="Center" Font-Bold="True" />
        <RowStyle Font-Size="12px"></RowStyle>
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <HeaderTemplate>
                    STT</HeaderTemplate>
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" Width="10%" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hình ảnh">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("image") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" 
                        ImageUrl='<%# Eval("image", "/images/slider/{0}") %>' Width="100px" />
                </ItemTemplate>
                <ItemStyle Width="20%" />
            </asp:TemplateField>
            <asp:BoundField DataField="name" HeaderText="Tên ảnh">
                <ItemStyle Width="20%" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Alt" DataField="alt">
                <ItemStyle Width="20%" />
            </asp:BoundField>
            <asp:BoundField DataField="link" HeaderText="link">
                <ItemStyle Width="20%" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="Thao tác">
                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                    Font-Underline="False" HorizontalAlign="Center" Width="10%" />
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
