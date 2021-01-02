<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jieyue.aspx.cs" Inherits="图书馆.library.jieyue" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="jieyue" runat="server">
    <div class="content">
        
        <asp:Label ID="Label1" runat="server" Text="请输入借阅图书的编号:"></asp:Label>
        <br />
        <br/>
        <asp:Label ID="Label6" runat="server" Text="图书编号"></asp:Label>&nbsp;
        <asp:TextBox ID="txtnumber" runat="server"></asp:TextBox>
        <br />
&nbsp;
        <asp:Label ID="Label7" runat="server" Text="或者"></asp:Label>
        &nbsp;<br />
        <asp:Label ID="Label8" runat="server" Text="输入名称+作者+出版社(三者缺一不可)："></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="图书名称"></asp:Label>
        &nbsp;<asp:TextBox ID="txtname" runat="server"></asp:TextBox> 
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="图书作者"></asp:Label>
        &nbsp;<asp:TextBox ID="txtwriter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="图书出版社"></asp:Label>
        &nbsp;<asp:TextBox ID="txtfrom" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
         &nbsp;&nbsp;<asp:Button ID="btnjieyue" runat="server" Text="借阅" onclick="btnjieyue_Click" /> &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="查询结果显示："></asp:Label>
        <br />
        <br/>
        <asp:Label ID="Label9" runat="server" Height="22px" Width="803px" 
            style="margin-bottom: 0px">借阅编号 书号 用户名  还书状态 书名  作者  出版社  借阅状态（1为已借，0为未借） </asp:Label>
         <br />
        <br />
         <asp:Label ID="LabelShow" runat="server" Height="100px" Width="733px"></asp:Label>
        
        <br />
        &nbsp;&nbsp;
         &nbsp;&nbsp;
        &nbsp;
                
        <br />
        <br />
        
        <br />
        <br />
       
        <br />
        
    </div>
    </form>
</body>
</html>
