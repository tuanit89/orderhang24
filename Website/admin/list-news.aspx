<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="list-news.aspx.cs" Inherits="Website.admin.list_news" %>
<%@ Import Namespace="tuanva.Core" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách bản tin
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="edit-news.aspx">
                        <span class="toolbar-insert"></span>
                        Thêm mới
                    </a>
                    <asp:LinkButton runat="server" ID="btnSetHot" onclick="btnSetHot_Click">
                        <span class="toolbar-update"></span>
                        Cập nhật
                    </asp:LinkButton>
                    <a><span class="toolbar-support"></span>Hướng dẫn </a></li>
            </ul>
        </div>
    </div>
    <div class="div-search clearfix">
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
    </div>
    <asp:GridView ID="GridNews" DataKeyNames="id" runat="server" AutoGenerateColumns="False"
        PageSize="20" HeaderStyle-Font-Size="12px" RowStyle-Font-Size="12px" EnableTheming="False"
        EmptyDataText="Không tìm thấy bản ghi nào" CssClass="tblList" GridLines="Vertical"
        Width="100%" AllowPaging="True"
        OnRowDeleting="GV_Product_RowDeleting" 
        OnRowEditing="GV_Product_RowEditing">
        <PagerStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        <HeaderStyle HorizontalAlign="Center" Font-Bold="True" />
        <RowStyle Font-Size="12px"></RowStyle>
        <Columns>
            <asp:TemplateField HeaderText="Tên bản tin">
                <ItemTemplate>
                    <%# Eval("title") %>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hình ảnh">
                <ItemTemplate>
                    <img style="width: 100px" src='/images/<%# Eval("image").Equals("")?"no_pic.png":("news/"+(int)Eval("id")/200+"/"+Eval("id")+"/"+Eval("image")) %>'/>
                </ItemTemplate>
                <ItemStyle Width="10%" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mô tả">
                <ItemTemplate><%# Eval("Description").ToString() %></ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Show trên trang chủ">
                <ItemTemplate>
                    <asp:CheckBox runat="server" ID="chkHot" Checked='<%# Eval("IsAttach") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="CreateDate" DataFormatString="{0:dd-MM-yyyy}" HeaderText="Ngày tạo"/>
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
