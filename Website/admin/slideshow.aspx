<%@ Page Title="" Language="C#" MasterPageFile="~/admin/UniAdmin.Master" AutoEventWireup="true" CodeBehind="slideshow.aspx.cs" Inherits="dongphucdangcap.com.admin.slideshow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách ảnh slideshow
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="edit-news.aspx">
                        <span class="toolbar-insert"></span>
                        Thêm mới
                    </a>
                    <a><span class="toolbar-support"></span>Hướng dẫn </a></li>
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
    <asp:GridView ID="GridNews" DataKeyNames="name" runat="server" AutoGenerateColumns="False"
        PageSize="20" HeaderStyle-Font-Size="12px" RowStyle-Font-Size="12px" EnableTheming="False"
        EmptyDataText="Không có hình nào" CssClass="tblList" GridLines="Vertical"
        Width="100%" AllowPaging="True"
        OnRowDeleting="GV_Product_RowDeleting" 
        OnRowEditing="GV_Product_RowEditing">
        <PagerStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        <HeaderStyle HorizontalAlign="Center" Font-Bold="True" />
        <RowStyle Font-Size="12px"></RowStyle>
        <Columns>
                <asp:TemplateField HeaderText="Hình ảnh">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Width="100%" ImageUrl='<%# Eval("name") %>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemStyle Height="110px" Width="40%" />
                </asp:TemplateField>
                <asp:BoundField DataField="size" HeaderText="File size">
                    <ItemStyle Width="15%" />
                </asp:BoundField>
                <asp:BoundField DataField="length" HeaderText="Dung lượng">
                    <ItemStyle Width="15%" />
                </asp:BoundField>
                <asp:BoundField DataField="date" HeaderText="Ngày tạo" 
                    DataFormatString="{0:dd/MM/yyyy HH:mm:ss}">
                    <ItemStyle Width="20%" HorizontalAlign="Left" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Xóa" ShowHeader="False">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                            OnClientClick="javascript:{ return confirm('Bạn có muốn xóa không?');}" />
                    </ItemTemplate>
                    <ItemStyle Width="10%" />
                </asp:TemplateField>
            </Columns>
    </asp:GridView>
</asp:Content>
