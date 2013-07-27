<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="list-product.aspx.cs" Inherits="Website.admin.list_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách sản phẩm
        </div>
        <div class="toolbar-action">
            <ul>
                <li><a href="edit-product.aspx"><span class="toolbar-insert"></span>Thêm mới </a><a><span class="toolbar-delete">
                </span>Xóa </a><a><span class="toolbar-support"></span>Hướng dẫn </a></li>
            </ul>
        </div>
    </div>
    <div class="div-search clearfix">
        <div style="float: left">
            Chọn danh mục
            <asp:DropDownList ID="DDL_ProductType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_ProductType_SelectedIndexChanged"
                Height="19px">
            </asp:DropDownList>
            &nbsp;có
            <%=n %>
            sản phẩm
        </div>
        <div style="float: right">
            <asp:DropDownList runat="server" ID="drpPageNum" AutoPostBack="True" 
                onselectedindexchanged="drpPageNum_SelectedIndexChanged" />
        </div>
    </div>
    <asp:GridView ID="GV_Product" DataKeyNames="id" runat="server" AutoGenerateColumns="False"
        HeaderStyle-Font-Size="12px" RowStyle-Font-Size="12px" EnableTheming="False"
        EmptyDataText="Không tìm thấy bản ghi nào" CssClass="tblList" GridLines="Vertical"
        Width="100%" AllowPaging="False" OnRowDeleting="GV_Product_RowDeleting" OnRowEditing="GV_Product_RowEditing">
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
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hình ảnh">
                <ItemTemplate>
                    <img src='<%# Eval("Image").Equals("")?"/ImageHandler.ashx?width=100&image=/Images/no_pic.png":"/Images/san-pham/"+(int)Eval("Id")/200+"/"+Eval("Id")+"/"+Eval("Image") %>' style="width: 100px"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên sản phẩm" DataField="productname" />
            <asp:BoundField HeaderText="Sản phẩm hot" DataField="IsHot"></asp:BoundField>
            <asp:BoundField HeaderText="Xem trang chủ" DataField="IsShowHome"></asp:BoundField>
            <asp:BoundField DataField="price" HeaderText="Giá" DataFormatString="{0:N0}">
                <ItemStyle Width="10%" />
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
