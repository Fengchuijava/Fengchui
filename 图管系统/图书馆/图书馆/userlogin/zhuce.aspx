<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zhuce.aspx.cs" Inherits="图书馆.userlogin.zhuce" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图书管理系统用户注册</title>
    <link href="../login.css" rel="stylesheet" type="text/css" />
    >
</head>
<body>
<center><h1 style="color:White;">图书管理系统<h1></center>
    <form id="login" runat="server" class="input">
    <h1>用户注册</h1>
    <div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="input" placeholder="请输入用户名"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="input" placeholder="清输入密码" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" CssClass="input" placeholder="清确认密码" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="注册"  OnClick="Button1_Click" CssClass="but" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" CssClass="but" />
    
    </div>
    </form>
</body>
</html>
