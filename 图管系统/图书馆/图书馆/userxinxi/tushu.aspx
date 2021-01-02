<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tushu.aspx.cs" Inherits="图书馆.userxinxi.tushu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label6" runat="server" Text="图书馆" onlick="Label_Click"></asp:Label>
        <br />
        <br />
        <hr/>
        <asp:Label ID="Label1" runat="server" Text="个人信息" onlick="Label1_Click"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="图书检索" onlick="Label2_Click"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="图书借阅" onlick="Label3_Click"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="图书归还" onlick="Label4_Click"></asp:Label>
        <br />
        
        <hr />
        <br />
        <asp:Label ID="Label5" runat="server" Text="退出登录" onlick="Label5_Click"></asp:Label>
    
    </div>
    </form>
</body>
</html>
