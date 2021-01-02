using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace 图书馆.houtai
{
    public partial class admin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //将用户名密码文本框设置为只读
                txtname.ReadOnly = true;
                txtpwd.ReadOnly = true;

                if ((Session["username"] == null) || (Session["pwd"] == null))
                {
                    //如果为空
                    //Console.Write("为空");
                }
                else
                {
                    //获取用户名和密码值

                    txtname.Text = Session["username"].ToString();
                    txtpwd.Text = Session["pwd"].ToString();

                }
            }
        }
        protected void btnxiugai_Click(object sender, EventArgs e)
        {
            //修改信息

 
            //将用户名密码文本框设置为可修改
            txtname.ReadOnly = false;
            //用户名不可修改
            txtpwd.ReadOnly = false;

            
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            //保存

            //获取未改动前的用户名
            string username = Session["username"].ToString();
            
            //修改信息后保存信息
            
            con.Open();
            string sql = "update admin set username='" + txtname.Text + "',pwd='" + txtpwd.Text + "' where username='"+username+"' ";//修改语句
            SqlCommand com = new SqlCommand(sql,con);
            com.ExecuteNonQuery();//执行语句
            con.Close();//关闭
            Response.Write("<script>alert('修改成功，已保存')</script>");

        }

        

        protected void btnadd_Click(object sender, EventArgs e)
        {
            //添加账户
            //注册方法
            //判断密码框两次输入一致
            if (TextBoxpwd.Text != "" && TextBoxpwd2.Text != "" && TextBoxname.Text != "")
            {
                if (TextBoxpwd.Text != TextBoxpwd2.Text)
                {
                    Response.Write("<script>alert('两次密码输入不一致，请重新输入')</script>");
                    //清空
                    TextBoxpwd.Text = "";
                    TextBoxpwd2.Text = "";
                }
                //注册
                
                con.Open();//打开数据库
                string sql = "INSERT INTO admin(username,pwd) VALUES('" + TextBoxname.Text + "','" + TextBoxpwd.Text + "')";
               SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();//执行语句
                con.Close();//关闭
                con.Dispose();//释放连接
                Response.Write("<script>alert('添加成功')</script>");
            }
            else {
                Response.Write("<script>alert('文本框为空！')</script>");
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            //清空
            TextBoxpwd.Text="";
            TextBoxpwd2.Text = "";
            TextBoxname.Text="";
        }
        
    }
    
}
