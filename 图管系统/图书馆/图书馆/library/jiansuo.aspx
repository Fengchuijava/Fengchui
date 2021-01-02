<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jiansuo.aspx.cs" Inherits="图书馆.library.jiansuo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../style.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="jiansuo" runat="server">
    <div class="content">
        
        <asp:Label ID="Label1" runat="server" Text="请输入该图书的名字或编号"></asp:Label>
        <br />
        <br/>
        <asp:TextBox ID="txtchaxun" runat="server"></asp:TextBox> &nbsp;&nbsp;
        <asp:Button ID="btnchaxun" runat="server" Text="查询" onclick="btnchaxun_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="Buttonchaxun" runat="server" onclick="Buttonchaxun_Click" 
            Text="查询该书的借阅编号" />
        
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="查询结果显示："></asp:Label>&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Height="22px" Width="733px" 
            style="margin-bottom: 0px">书号     书名    作者      出版社     书描述     借阅状态（1为已借，0为未借） </asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelShow" runat="server" Height="100px" Width="684px"></asp:Label>
        
        <br />
        该书借阅编号为（书被借出时）：<br />
        
        <br />
        <asp:Label ID="Labelxianshi" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        
        
        <br />
        
    </div>
    </form>
</body>
</html>
