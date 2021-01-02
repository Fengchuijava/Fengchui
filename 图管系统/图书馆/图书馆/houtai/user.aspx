<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="图书馆.houtai.user" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h3>用户信息</h3>
    <div style="margin:30px">
    <h5>查看和删除用户：</h5>
        <asp:Label ID="Label1" runat="server" Text="请输入用户名："></asp:Label>
        <br />
        <br/>
        <asp:TextBox ID="txtchaxun" runat="server"></asp:TextBox> &nbsp;&nbsp;
        <asp:Button ID="btnchaxun" runat="server" Text="查询" onclick="btnchaxun_Click" />
        
        &nbsp;&nbsp;
        <asp:Button ID="btndelete" runat="server" onclick="btndelete_Click" 
            Text="删除该用户" />
        
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="查询结果显示："></asp:Label>&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Height="22px" Width="733px" 
            style="margin-bottom: 0px">用户名  密码</asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelShow" runat="server" Height="43px" Width="672px"></asp:Label>
        
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="查询所有用户" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="name" DataSourceID="SqlDataSource1" Visible="False">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" 
                    SortExpression="name" />
                <asp:BoundField DataField="password" HeaderText="password" 
                    SortExpression="password" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:dbString %>" 
            SelectCommand="SELECT * FROM [usertable]"></asp:SqlDataSource>
        
        <br />
    </div>
    
    </form>
</body>
</html>
