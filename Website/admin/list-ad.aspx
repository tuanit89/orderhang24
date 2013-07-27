<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="list-ad.aspx.cs" Inherits="Website.admin.list_ad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="navi-action">
        <div class="clear"></div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách quảng cáo
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="edit-ad.aspx">
                        <span class="toolbar-insert"></span>
                        Thêm mới
                    </a>
                 </li>
            </ul>
        </div>
        <div class="div-search clearfix">
        <div style="float: left">
            Chọn danh mục
            <asp:DropDownList ID="drpLocation" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpLocation_SelectedIndexChanged">
                <asp:ListItem Value="ad" Text="Quảng cáo" />
                <asp:ListItem Value="partner" Text="Đối tác" />
                <asp:ListItem Value="bodyhome" Text="Thân trang chủ" />
            </asp:DropDownList>
        </div>
    </div>
    </div>
    <asp:GridView runat="server" CssClass="tblList" ID="grvUser" DataKeyNames="id"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting" 
         onrowediting="grvUser_RowEditing" AllowPaging="True" PageSize="10" 
         onselectedindexchanging="grvUser_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <ItemTemplate>
                   <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên QC" DataField="Name"/>
            <asp:BoundField HeaderText="Mô tả" DataField="Description"/>
            <asp:TemplateField HeaderText="Hình ảnh">
                <ItemTemplate><img src='/Images/<%# Eval("Location")%>/<%# Eval("Image").Equals("")?"no-image.png":Eval("Image") %>' width="100px"/></ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Liên kết" DataField="Link"/>
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
