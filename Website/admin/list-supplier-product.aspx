<%@ Page Title="Danh mục nhà cung cấp" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="list-supplier-product.aspx.cs" Inherits="Website.admin.list_supplier_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách nhà sản xuất
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="edit-supplier-product.aspx"><span class="toolbar-insert"></span>Thêm mới</a>
                </li>
            </ul>
        </div>
    </div>
    <asp:GridView ID="GV_Product" DataKeyNames="id" runat="server" AutoGenerateColumns="False"
        PageSize="20" HeaderStyle-Font-Size="12px" RowStyle-Font-Size="12px" EnableTheming="False"
        EmptyDataText="Không tìm thấy bản ghi nào" CssClass="tblList" GridLines="Vertical"
        Width="100%" AllowPaging="True" OnPageIndexChanging="GV_Product_PageIndexChanging"
        OnRowDeleting="GV_Product_RowDeleting" 
        OnRowEditing="GV_Product_RowEditing" onrowdatabound="GV_Product_RowDataBound">
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
            <asp:TemplateField HeaderText="Tên nhà cung cấp">
                <ItemTemplate>
                    <p class="textleft"><%# Eval("Name")%></p>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Left" ></ItemStyle>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Mô tả" DataField="description" />
            <asp:BoundField HeaderText="Mô tả SEO" DataField="metadescription" />
            <asp:BoundField HeaderText="Sắp xếp" DataField="Sort" />
            <asp:TemplateField HeaderText="Thao tác">
                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                    Font-Underline="False" HorizontalAlign="Center" Width="10%" />
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                         />
                    <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Edit" CommandArgument='<%# Eval("id") %>'
                        ImageUrl="/admin/images/edit.gif" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
