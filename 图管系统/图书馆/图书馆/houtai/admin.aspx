<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="图书馆.houtai.admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #left
        {
            float:left;
            margin:10px 30px 10px 50px;
            width:500px;
            }
        #right
        {  
            margin:10px 30px 10px 50px;
            
            }
    </style>
    
</head>
<body>
    <h4>管理员信息</h4>
    <form id="lform" runat="server">
    <div id="left">
    <h5>修改账户信息：</h5>
    <p /><asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="txtname" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="labelpwd" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="txtpwd" runat="server" ReadOnly="True" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnxiugai" runat="server" Text="修改信息" 
            onclick="btnxiugai_Click" /> &nbsp;<asp:Button ID="btnsave" runat="server" Text="保存" onclick="btnsave_Click" 
            style="height: 27px" />
    &nbsp;&nbsp;
        
        
    
    <p style="margin-left: 40px">
        &nbsp;</p>
    </div>
    <hr />
     <div id="right">
         <h5>添加管理员账户：</h5>
         <asp:Label ID="Label2" runat="server" Text="用户名："></asp:Label>
         <asp:TextBox ID="TextBoxname" runat="server"></asp:TextBox><br /><br />
         <asp:Label ID="Label3" runat="server" Text="密码："></asp:Label>
         <asp:TextBox ID="TextBoxpwd" runat="server" TextMode="Password"></asp:TextBox>
         <br /><br />
         <asp:Label ID="Label4" runat="server" Text="密码："></asp:Label>
         <asp:TextBox ID="TextBoxpwd2" runat="server" TextMode="Password"></asp:TextBox>
         <br />
         <br />
         <asp:Button ID="btnadd" runat="server" Text="添加账户" onclick="btnadd_Click" />&nbsp;
         <asp:Button ID="btnclear" runat="server" Text="清空" onclick="btnclear_Click" />
    </div>
     <hr />
     </form>
      
   
   
</body>
</html>
