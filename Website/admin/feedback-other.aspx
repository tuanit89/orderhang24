<%@ Page Title="Quản lý danh sách liên hệ" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true" CodeBehind="feedback-other.aspx.cs" Inherits="Website.admin.feedback_other" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="toolbar clearfix">
        <div class="toolbar-title">
            Danh sách khách hàng liên hệ tới website
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <a href="default.aspx">
                        <span class="toolbar-update-back"></span>
                        Trở lại
                    </a>
                 </li>
            </ul>
        </div>
    </div>
    <h3 style="margin-top: 20px;padding-top:5px;border-top:2px solid #6381C0;">Danh sách liên hệ</h3>
        <asp:GridView runat="server" CssClass="tblList" ID="grvContact" DataKeyNames="id"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting" AllowPaging="True" PageSize="10" 
         onselectedindexchanging="grvUser_SelectedIndexChanging" EmptyDataText="Hiện tại không có liên hệ nào">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <ItemTemplate>
                   <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên KH" DataField="FullName"/>
            <asp:BoundField HeaderText="Email" DataField="Email"/>
            <asp:BoundField HeaderText="SĐT" DataField="Phone"/>
            <asp:BoundField HeaderText="Tiêu đề" DataField="Subject"/>
            <asp:BoundField HeaderText="Nội dung" DataField="Message"/>
            <asp:TemplateField HeaderText="Thao tác">
               <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="/admin/images/action_delete.gif"
                        OnClientClick="javascript:{ return confirm('Bạn chắc muốn xóa chứ?');}" />
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
