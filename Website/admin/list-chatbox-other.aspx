<%@ Page Title="Admin panel - Danh sách người dùng" Language="C#" MasterPageFile="~/admin/UniAdmin.Master" AutoEventWireup="true" CodeBehind="list-chatbox-other.aspx.cs" Inherits="dongphucdangcap.com.admin.list_chatbox_other" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="navi-action">
        <div class="clear"></div>
    </div>
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách phản hồi liên hệ
        </div>
    </div>
    <div style="padding: 10px 0 0 0">
        Chọn loại liên lạc: 
          <asp:DropDownList runat="server" ID="drpType" AutoPostBack="True" 
        onselectedindexchanged="drpType_SelectedIndexChanged">
                <asp:ListItem Value="0">[- Tất cả -]</asp:ListItem>
                <asp:ListItem Value="1">Ý kiến</asp:ListItem>
                <asp:ListItem Value="2">Liên hệ</asp:ListItem>
            </asp:DropDownList>
    </div>
            
    <asp:GridView runat="server" CssClass="tblList" ID="grvUser" DataKeyNames="id"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting">
        <Columns>
            <asp:BoundField HeaderText="Tên KH" DataField="ContactName"/>
            <asp:BoundField HeaderText="SĐT" DataField="Phone"/>
            <asp:BoundField HeaderText="Địa chỉ" DataField="Address"/>
            <asp:BoundField HeaderText="Email" DataField="Email"/>
            <asp:BoundField HeaderText="Nội dung" DataField="Content"/>
             <asp:TemplateField HeaderText="Thao tác">
               <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                        OnClientClick="javascript:{ return confirm('Bạn có muốn xóa không?');}" />
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
</asp:Content>
