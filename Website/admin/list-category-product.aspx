<%@ Page Title="Danh mục sản phẩm" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="list-category-product.aspx.cs" Inherits="Website.admin.list_category_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function check(id) {
            if(id==0) {
                return confirm("Bạn đang muốn xóa nhóm cha, nếu xóa nhóm cha các phần tử thuộc nhóm này sẽ bị mất? Bạn chắc chứ?");
            }
            return confirm("Bạn chắc chắn muốn xóa?");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách nhóm sản phẩm
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="edit-category-product.aspx"><span class="toolbar-insert"></span>Thêm mới</a>
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
            <asp:TemplateField HeaderText="Tên nhóm S.Phẩm">
                <ItemTemplate>
                    <p class="textleft"><%# Eval("Name")%></p>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Left" ></ItemStyle>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Mô tả" DataField="description" />
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
