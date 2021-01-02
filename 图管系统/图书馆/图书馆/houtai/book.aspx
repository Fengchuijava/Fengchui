<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="图书馆.houtai.book" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
         #left
        {
            float:left;
            margin:10px 30px 10px 50px;
             width: 600px;
             
         }
        #right
        {  
            
            margin:10px 30px 10px 50px;
            height:500px;
            
            }
         #form1
         {
             height: 574px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h3>图书信息</h3>
    <div id="left">
    <h5>查询和删除图书：</h5>
        <asp:Label ID="Label1" runat="server" Text="请输入该图书的名字或编号"></asp:Label>
        <br />
        <br/>
        <asp:TextBox ID="txtchaxun" runat="server"></asp:TextBox> &nbsp;&nbsp;
        <asp:Button ID="btnchaxun" runat="server" Text="查询" onclick="btnchaxun_Click" />
        
        &nbsp;&nbsp;
        <asp:Button ID="btndelete" runat="server" onclick="btndelete_Click" 
            Text="删除该书" />
        
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="查询结果显示："></asp:Label>&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Height="22px" Width="733px" 
            style="margin-bottom: 0px">书号     书名    作者      出版社     书描述     借阅状态（1为已借，0为未借） </asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelShow" runat="server" Height="43px" Width="550px"></asp:Label>
        
        <br />
        
        <br />
        
        <br />

        <br />
        <asp:Button ID="btnsuoyou" runat="server" Text="查询所有图书" 
            onclick="btnsuoyou_Click" />
        <br />
        <br />
        所有图书：<br />
        &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="booknumber" DataSourceID="SqlDataSource1" Visible="False">
            <Columns>
                <asp:BoundField DataField="booknumber" HeaderText="booknumber" ReadOnly="True" 
                    SortExpression="booknumber" />
                <asp:BoundField DataField="bookname" HeaderText="bookname" 
                    SortExpression="bookname" />
                <asp:BoundField DataField="bookfrom" HeaderText="bookfrom" 
                    SortExpression="bookfrom" />
                <asp:BoundField DataField="bookwriter" HeaderText="bookwriter" 
                    SortExpression="bookwriter" />
                <asp:BoundField DataField="bookm" HeaderText="bookm" SortExpression="bookm" />
                <asp:BoundField DataField="bookstatus" HeaderText="bookstatus" 
                    SortExpression="bookstatus" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:dbString %>" 
            SelectCommand="SELECT * FROM [book]"></asp:SqlDataSource>

    </div>
    
    <div id="right">
    <hr color="blue"/>
        <h5>添加图书：：</h5>
        <br />
        <asp:Label ID="Label10" runat="server" Text="图书编号："></asp:Label>
        <asp:TextBox ID="TextBoxno" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="图书名称："></asp:Label>
        <asp:TextBox ID="TextBoxname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="图书作者："></asp:Label>
        <asp:TextBox ID="TextBoxw" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="出版社："></asp:Label>
        <asp:TextBox ID="TextBoxfrom" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="详情描述："></asp:Label>
        <asp:TextBox ID="TextBoxm" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Buttonadd" runat="server" onclick="Buttonadd_Click" 
            Text="添加图书" />
&nbsp;&nbsp;
        <asp:Button ID="Buttonclear" runat="server" onclick="Button1_Click" Text="清空" />
        <br />
         <hr color="blue"/>
    </div>
    
    </form>
</body>
</html>
