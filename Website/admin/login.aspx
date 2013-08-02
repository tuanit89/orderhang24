<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Website.admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập quản trị website Điện lạnh Minh Tâm</title>
    <style type="text/css">
        body
        {
            background-image: url(/Content/admin/bg-khungdangnhap.gif);
            background-repeat: repeat-x;
            margin-left: 0px;
            margin-top: 0px;
            margin-right: 0px;
            margin-bottom: 0px;
            background-color: #0282d1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td height="90">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <div align="center">
                    <table width="590" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td height="398" valign="top" background="/Content/admin/bgdangnhap.gif" style="padding-left: 150px">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td height="100">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <table width="100%" border="0" cellspacing="3" cellpadding="3">
                                                <tr>
                                                    <td width="46%">
                                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" CssClass="style1"
                                                            Text="Tên:" />
                                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                            ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                    </td>
                                                    <td width="54%">
                                                        <asp:TextBox ID="UserName" runat="server" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" CssClass="style1"
                                                            Text="Mật khẩu" /><asp:RequiredFieldValidator ID="PasswordRequired" runat="server"
                                                                ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required."
                                                                ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                    </td>
                                                    <td style="text-align: left">
                                                        <asp:CheckBox ID="RememberMe" runat="server" CssClass="style1" Text="Nhớ mật khẩu." />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2" style="color: Red;">
                                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                                                            ValidationGroup="Login1" onclick="LoginButton_Click" />
                                                        <label>
                                                            <input type="reset" name="Submit2" value="Reset">
                                                        </label>
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
