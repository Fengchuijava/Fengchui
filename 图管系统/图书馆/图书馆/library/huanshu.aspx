<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="huanshu.aspx.cs" Inherits="图书馆.library.huanshu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="huanshu" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="请输入你要归还的书的借书编号："></asp:Label>
       
        <br />
        <br/>
        <asp:Label ID="Label3" runat="server" Text="借阅编号"></asp:Label>
        &nbsp;<asp:TextBox ID="txtsno" runat="server"></asp:TextBox> 
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="温馨提示：可以输入借阅编号和借阅人用户名帮他人还书额"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="借阅人用户名"></asp:Label> &nbsp;
        <asp:TextBox ID="TextBoxname" runat="server"></asp:TextBox>
        <br />
        &nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnguihuan" runat="server" Text="归还" 
            onclick="btnjieyue_Click" />
         &nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="归还结果显示："></asp:Label> &nbsp;<br />
        <br />
        <asp:Label ID="Label9" runat="server" Height="22px" Width="812px" 
            style="margin-bottom: 0px">借阅编号 书号 用户名  还书状态    还书用户     书名  作者  出版社  借阅状态（1为已借，0为未借）   还书用户 </asp:Label>
         <br />
        <br />
         <br />
        <asp:Label ID="LabelS" runat="server" Height="100px" Width="579px"></asp:Label>
        
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
