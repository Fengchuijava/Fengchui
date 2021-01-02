<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tushu.aspx.cs" Inherits="图书馆.library.tushu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图书馆管理系统</title>
    <style type="text/css">
        #nav
        {
            background:#BBFFEE;
            height:50px;
            padding:20px 0 0 10px;
            }
        #nav   li
        {
            list-style:none;
            float:left;
            margin-left:10px;
            }
       #content
       {
           width:100%;
           height:auto;
           }
       .main
       {
           
           width:100%;
           height:500px;
           }
       
       .hy{
           text-decoration:none;   
           }
    </style>
    
</head>
<body>
    <form id="tushu" runat="server">
    <h3>图书管理系统</h3>
    <hr/>
    <div id="nav">
    <!--左侧菜单项-->       
              
            <asp:HyperLink ID="HyperLink1" runat="server" Target="default" 
            CssClass="hy" NavigateUrl="~/library/index.aspx">首页</asp:HyperLink>&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" Target="default"
                NavigateUrl="~/library/xinxi.aspx" CssClass="hy">个人信息</asp:HyperLink>&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" Target="default" 
            CssClass="hy" NavigateUrl="~/library/jiansuo.aspx">图书检索</asp:HyperLink>&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" Target="default"
            CssClass="hy" NavigateUrl="~/library/huanshu.aspx">图书归还</asp:HyperLink>&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink5" runat="server" Target="default" CssClass="hy" NavigateUrl="~/library/jieyue.aspx">图书借阅</asp:HyperLink>&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink6" runat="server" CssClass="hy" 
            NavigateUrl="~/userlogin/zhuxiao.ashx">注销</asp:HyperLink>
                  
    
    </div>
    <br/>
    <hr/>
   
    <div id="content">
        <!--右侧内容页-->
        <iframe class="main" name="default" id="frm" runat="server" src="index.aspx"></iframe>
    </div>
    </form>
</body>
</html>
