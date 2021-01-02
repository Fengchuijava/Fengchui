using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace 图书馆.library
{
    public partial class xinxi : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){

            //将用户名密码文本框设置为只读
            txtname.ReadOnly = true;
            txtpwd.ReadOnly = true;
      
                 if ((Session["userid"] == null) || (Session["password"]==null)){
                    //如果为空
                     //Console.Write("为空");
                 }else{
                     //获取用户名和密码值

                txtname.Text = Session["userid"].ToString();
                txtpwd.Text =Session["password"].ToString();

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
            string username = Session["userid"].ToString();
            
            //修改信息后保存信息
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
            con.Open();
            string sql = "update usertable set name='" + txtname.Text + "',password='" + txtpwd.Text + "' where name='"+username+"' ";//修改语句
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();//执行语句
            con.Close();//关闭
            Response.Write("<script>alert('修改成功，已保存')</script>");

        }

        protected void btnfanhui_Click(object sender, EventArgs e)
        {
            //返回
            Response.Redirect("index.aspx");//返回首页
        }
        
    }
}