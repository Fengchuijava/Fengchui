using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.SqlClient;
//using System.Data.Odbc;

using System.Data.OleDb;
namespace 图书馆
{
    public partial class zhuce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("欢迎来到注册界面");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //注册按钮
            register();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //返回按钮（登录界面）
            Response.Redirect("login.aspx");
        }
        protected void register()
        {
            //注册方法
            //判断密码框两次输入一致
            if(TextBox2.Text!=TextBox3.Text){
                Response.Write("<script>alert('两次密码输入不一致，请重新输入')</script>");
                //清空
                TextBox2.Text="";
                TextBox3.Text = "";
            }
            //注册
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\试做\ASP.NET技术开发\图管系统\图书馆\data\library.accdb";
            OleDbConnection con = new OleDbConnection(str);//创建数据库连接
            con.Open();//打开数据库
            string sql = "INSERT INTO usertable([name],[password]) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();//执行语句
            con.Close();//关闭
            con.Dispose();//释放连接
            Response.Write("<script>alert('注册成功')</script>");




            /**
            string str="server=localhost;database=library;uid=root;pwd=123;";//数据库配置文本
            SqlConnection sqlcon = new SqlConnection(str);//连接到数据库
            sqlcon.Open();//打开连接对象
            string sql = "insert into 用户信息表(用户名,密码) values('"+TextBox1.Text+"','"+TextBox2.Text+"')";//sql语句文本
            SqlCommand com = new SqlCommand(sql, sqlcon);//执行sql语句
            //com.ExecuteNonQuery();
            sqlcon.Close();//关闭数据库
            Response.Write("已添加成功");

            **/
            
        }
    }
}