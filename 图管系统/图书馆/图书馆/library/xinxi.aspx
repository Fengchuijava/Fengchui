<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xinxi.aspx.cs" Inherits="图书馆.library.xinxi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../style.css" rel="stylesheet" type="text/css" />
    
    
</head>
<body class="content">
    
    <form id="xinxi" runat="server" method="post" height="500px">
    
    
    <div class="content">
    <h3>个人信息</h3>
    <hr/>
    
        <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="txtname" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="labelpwd" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="txtpwd" runat="server" ReadOnly="True" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnxiugai" runat="server" Text="修改信息" 
            onclick="btnxiugai_Click" /> &nbsp; &nbsp;
        
        <asp:Button ID="btnfanhui" runat="server" Text="返回" onclick="btnfanhui_Click" />
    
    <p style="margin-left: 40px">
        <asp:Button ID="btnsave" runat="server" Text="保存" onclick="btnsave_Click" 
            style="height: 27px" />
    </p>
    <p>
        &nbsp;</p>
    </div>
    </form>
</body>
</html>
