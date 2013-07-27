<%@ Page Title="Quản lý thuộc tính của nhóm sản phẩm" Language="C#" MasterPageFile="~/admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="feature-value-product.aspx.cs" Inherits="Website.admin.feature_value_product" %>

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
                    <a href="feature-value-product.aspx"><span class="toolbar-update-back"></span>Hủy sửa</a>
                    <asp:LinkButton runat="server" ID="InsertAndBack" onclick="InsertAndBack_Click">
                        <span class="toolbar-update"></span>
                        Lưu và trở lại
                    </asp:LinkButton>
                 </li>
            </ul>
        </div>
    </div>
    <div class="div-search clearfix">
        <div style="float: left">
            Chọn danh mục
            <asp:DropDownList runat="server" ID="drpNhomSP" AutoPostBack="True" 
                onselectedindexchanged="drpNhomSP_SelectedIndexChanged" />
            <asp:DropDownList runat="server" ID="drpThuocTinh" />
            <asp:Button runat="server" ID="btnChanger" OnClick="btnChangers" Text="Xem ds thuộc tính này"/>
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
                    Giá trị</td>
                <td class="tblSkinValueColumn">
                    <asp:TextBox runat="server" ID="txtFuncName" Width="99%"/>
                </td>
            </tr>
        </tbody>
    </table>
    
      <h3 style="margin-top: 20px;padding-top:5px;border-top:2px solid #6381C0;">Danh sách giá trị của thuộc tính</h3>
        <asp:GridView runat="server" CssClass="tblList" ID="grvPromote" DataKeyNames="id"
        AutoGenerateColumns="False" onrowdeleting="grvUser_RowDeleting" 
         onrowediting="grvUser_RowEditing" AllowPaging="True" PageSize="10" 
         onselectedindexchanging="grvUser_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="STT">
                <ItemTemplate>
                   <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Giá trị thuộc tính" DataField="Value"/>
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
