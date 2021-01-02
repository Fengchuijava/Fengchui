<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="图书馆.userlogin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图书管理系统用户登录</title>
    <link href="../login.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
   <center><h1 style="color:White;">图书管理系统<h1></center>
    <form id="login" runat="server" method="post" class="input">
        <h1>Login</h1>    
        <asp:TextBox ID="TextBox1" runat="server" CssClass="input" placeholder="请输入用户名" ></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="input" placeholder="请输入密码" TextMode="Password"></asp:TextBox>  
         <br />
         <br />
        <asp:Label ID="Label3" runat="server" Text="用户类型："></asp:Label>
        <asp:DropDownList ID="t" runat="server" Height="16px">
        <asp:ListItem Value="1">用户</asp:ListItem>
        <asp:ListItem Value="0">管理员</asp:ListItem>
        </asp:DropDownList>
        <br/>
        <br/>

    <asp:Button ID="Button1" runat="server" Text="登录"  OnClick="Button1_Click" 
            CssClass="but"/><br/>
    <asp:Button ID="Button2" runat="server" Text="注册"  OnClick="Button2_Click" 
            CssClass="but"/>
   
    </form>
 
</body>
</html>
