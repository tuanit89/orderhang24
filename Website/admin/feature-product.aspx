<%@ Page Title="Quản lý tính năng nhóm sản phẩm" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="True"
    CodeBehind="feature-product.aspx.cs" Inherits="Website.admin.feature_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="toolbar clearfix">
        <div class="toolbar-title">
            <%= (!IsEdit?"Thêm mới":"Sửa nhóm")+" tính năng dòng sản phẩm" %>
        </div>
        <div class="toolbar-action">
            <ul>
                <li>
                    <asp:LinkButton runat="server" ID="InsertAndBack" onclick="InsertAndBack_Click">
                        <span class="toolbar-delete"></span>
                        Lưu và trở lại
                    </asp:LinkButton>
                 </li>
            </ul>
        </div>
    </div>
    <div class="div-search clearfix">
        <div style="float: left">
            Chọn danh mục
            <asp:DropDownList runat="server" ID="drpNhomSP" />
            <asp:Button runat="server" ID="btnChanger" OnClick="btnChangers" Text="Chọn"/>
        </div>
       <%-- <div style="float: right">
            <input type="text" class="inputSearch"/>
            <input type="button" class="buttonSearch"/>
        </div>--%>
    </div>
     <table width="100%" class="tblDetailSkin">
        <tbody>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tên tính năng</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtFuncName" Width="99%"/>
                </td>
            </tr>
            <tr class="tblSkinRow">
                <td class="tblSkinHeaderColumn">
                    Tính năng chung?</td>
                <td class="tblSkinValueColumn">
                    <asp:CheckBox runat="server" ID="chkShare"/>
                </td>
            </tr>
        </tbody>
    </table>
    
      <h3 style="margin-top: 20px;padding-top:5px;border-top:2px solid #6381C0;">Danh sách giá trị khuyến mại</h3>
        <asp:GridView runat="server" CssClass="tblList" ID="grvPromote" DataKeyNames="id"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting" 
         onrowediting="grvUser_RowEditing" AllowPaging="False"
         onselectedindexchanging="grvUser_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <ItemTemplate>
                   <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên thuộc tính" DataField="FeatureName"/>
            <asp:BoundField HeaderText="Thuộc nhóm sản phẩm" DataField="CateProductName"/>
            <asp:TemplateField HeaderText="Thuộc tính chia sẻ">
                <ItemTemplate>
                    <%# Eval("IsShare").ToString()=="False"?"Không":"Có" %>
                </ItemTemplate>
            </asp:TemplateField>
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
