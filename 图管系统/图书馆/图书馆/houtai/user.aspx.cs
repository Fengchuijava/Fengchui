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
    public partial class user : System.Web.UI.Page
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            //删除用户
            if (txtchaxun.Text == "")
            {
                Response.Write("<script>alert('文本框为空，请先输入值')</script>");
            }
            else
            {
                
                con.Open();//打开数据库
                string sql = "delete from usertable where name='" + name + "'";//删除语句
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();//执行语句
                con.Close();
                LabelShow.Text = "";//清空显示框
                LabelShow.Text = "该用户已被删除";
            }
        }

        protected void btnchaxun_Click(object sender, EventArgs e)
        {
            //查询用户
            //判断查询框是否为空
            if (txtchaxun.Text == "")
            {
                Response.Write("<script>alert('文本框为空，请先输入值')</script>");
            }
            else
            {
                //查询
               
                con.Open();//打开数据库
                string sql = "select * from usertable where name='" + txtchaxun.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader db = com.ExecuteReader();//执行语句
                //陆续读数据
                if (db.Read())
                {
                    //结果显示
                    name = db[0].ToString();//图书编号
                    LabelShow.Text = db[0].ToString() + " " + db[1].ToString();
                    db.Close();
                    con.Close();//关闭
                    Response.Write("<script>alert('查询成功')</script>");

                }
                else
                {
                    LabelShow.Text = "未查到该用户";

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //查询所有用户
            GridView1.Visible = true;
        }

    }
}