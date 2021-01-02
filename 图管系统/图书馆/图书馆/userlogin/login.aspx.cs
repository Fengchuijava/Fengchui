using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace 图书馆.userlogin
{
    public partial class login: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //登录按钮

            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                //用户名、密码为空
                Response.Write("<script>alert('用户名或密码为空，请输入')</script>");

            }
            else {
                //登录方法
                denglu();
                            
            }
          
            

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //注册按钮
            //注册方法
            Response.Redirect("zhuce.aspx");
        }
        protected void denglu()
        {
            //string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\试做\ASP.NET技术开发\图管系统\图书馆\图书馆\App_Data\Library.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);//创建数据库连接
            con.Open();//打开
            //判断是用户还是管理员
            if (t.SelectedItem.Value == "1")
            {
                //用户
                string sql = "select * from usertable where name=@userid and password=@password and type=@usertype";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("userid", TextBox1.Text);
                com.Parameters.AddWithValue("password", TextBox2.Text);
                com.Parameters.AddWithValue("usertype", t.SelectedItem.Value);

                SqlDataReader read = com.ExecuteReader();

                if (read.Read())
                {//陆续读入输入文本框的值
                    //会话存储
                    Session["userid"] = TextBox1.Text;
                    Session["password"] = TextBox2.Text;
                    //Session["usertype"] = t.SelectedItem.Value;

                    //用户名和密码与数据库对应，成功登录
                    Response.Write("<script>alert('欢迎" + Session["userid"] + ",您成功登录!')</script>");
                    //登录成功，然后进入系统
                    Response.Redirect("../library/tushu.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误')</script>");

                }
            }
            else { 
                //管理员
                string adminsql = "select * from admin where username=@username and pwd=@pwd and type=@type";
                SqlCommand admincom = new SqlCommand(adminsql, con);
                admincom.Parameters.AddWithValue("username", TextBox1.Text);
                admincom.Parameters.AddWithValue("pwd", TextBox2.Text);
                admincom.Parameters.AddWithValue("type", t.SelectedItem.Value);

                SqlDataReader adminread = admincom.ExecuteReader();

                if (adminread.Read())
                {//陆续读入输入文本框的值
                    //会话存储
                    Session["username"] = TextBox1.Text;
                    Session["pwd"] = TextBox2.Text;
                    //Session["type"] = t.SelectedItem.Value;

                    //用户名和密码与数据库对应，成功登录
                    Response.Write("<script>alert('欢迎" + Session["username"] + ",您成功登录!')</script>");
                    //登录成功，然后进入后台
                    Response.Redirect("../houtai/guanli.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误')</script>");

                }
            }
           
            con.Close();

            }

                
            
        
    }
}