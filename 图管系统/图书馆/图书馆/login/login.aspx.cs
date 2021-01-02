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
    public partial class login: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //登录按钮
            //登录方法
            denglu();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //注册按钮
            //注册方法
            Response.Redirect("zhuce.aspx");
        }
        protected void denglu()
        {

            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\试做\ASP.NET技术开发\图管系统\图书馆\data\library.accdb";
            OleDbConnection con = new OleDbConnection(str);
            con.Open();//打开
            string sql = "select * from usertable where name=@userid and password=@password and type=@usertype";
            OleDbCommand com = new OleDbCommand(sql,con);
            com.Parameters.AddWithValue("userid",TextBox1.Text);
            com.Parameters.AddWithValue("password", TextBox2.Text);
            com.Parameters.AddWithValue("usertype", t.SelectedItem.Value);
            
            OleDbDataReader read=com.ExecuteReader();
            if (read.Read())
                {//陆续读入输入文本框的值
                    Session["userid"] = TextBox1.Text;
                    Session["password"] = TextBox2.Text;
                    Session["usertype"] = t.SelectedItem.Value;
                    //用户名和密码与数据库对应，成功登录
                    Response.Write("<script>alert('欢迎" + Session["userid"] + ",您成功登录!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误')</script>");

                }
            con.Close();

            /*
            string str = "server=localhost;uid=root;pwd=123;database=library;pooling=true";//连接到数据库
            SqlConnection sqlcon = new SqlConnection(str);//创建Sq;Connection（数据库连接）对象              
                sqlcon.Open();//打开连接对象
                //存储sql语句
                string sql = "select * from usertable where name=@userid and password=@password and type=@usertype";
                SqlCommand com = new SqlCommand(sql, sqlcon);//创建SqlCommand对象，来执行语句和存储调用
                //给sql对象sql语句中参数进行赋值
                com.Parameters.AddWithValue("userid", TextBox1.Text);
                com.Parameters.AddWithValue("password", TextBox2.Text);
                com.Parameters.AddWithValue("usertype",t.SelectedItem.Value);
                
                SqlDataReader read = com.ExecuteReader();//返回一个数据流
                //判断输入的用户名和密码、选择的用户类型
                if (read.Read())
                {//陆续读入输入文本框的值
                    Session["userid"] = TextBox1.Text;
                    Session["password"] = TextBox2.Text;
                    Session["usertype"] = t.SelectedItem.Value;
                    //用户名和密码与数据库对应，成功登录
                    Response.Write("<script>alert('欢迎" + Session["userid"] + ",您成功登录!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误')</script>");

                }
            sqlcon.Close();
            */
            
            }

                
            
        
    }
}