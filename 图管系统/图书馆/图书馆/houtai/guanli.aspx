<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guanli.aspx.cs" Inherits="图书馆.houtai.guanli" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理</title>
    <style type="text/css">
        #left
        {
            float:left;
            margin:10px 50px 0px 20px; 
            width:20%;
            background:#bbffee;
            text-align:center;
            height:500px;
            }
        #right
        {
            margin:10px; 
            }   
       #frame
       {
           width:70%;
            height:500px;
           } 
        .hy{
           text-decoration:none;   
           }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <h2>后台管理界面</h2>
    <hr />
    <div id="left">
        
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" target="iframe" 
                NavigateUrl="~/houtai/admin.aspx" CssClass="hy">管理员信息</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" target="iframe" CssClass="hy" 
                NavigateUrl="~/houtai/book.aspx">图书信息</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink5" runat="server" target="iframe" CssClass="hy" 
                NavigateUrl="~/houtai/user.aspx">用户信息</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink6" runat="server" 
                NavigateUrl="~/userlogin/zhuxiao.ashx" CssClass="hy">注销</asp:HyperLink>
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
    </div>
    <div id="right">
        <iframe name="iframe" src="admin.aspx" id="frame"></iframe>
    </div>
    </form>
</body>
</html>
