<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="图书馆.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录界面</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="密 码："></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="用户类型："></asp:Label>
    <asp:DropDownList ID="t" runat="server" Height="16px">
        <asp:ListItem Value="1">用户</asp:ListItem>
        <asp:ListItem Value="0">管理员</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="登录"  OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="注册"  OnClick="Button2_Click"/>
    </form>
</body>
</html>
