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
    public partial class book : System.Web.UI.Page
    {
        public static string booknumber;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btndelete_Click(object sender, EventArgs e)
        {
            //删除图书
            if (txtchaxun.Text == "")
            {
                Response.Write("<script>alert('文本框为空，请先输入值')</script>");
            }
            else
            {
                //string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\试做\ASP.NET技术开发\图管系统\图书馆\图书馆\App_Data\Library.mdf;Integrated Security=True;User Instance=True";
                
                con.Open();//打开数据库
                string sql = "delete from book where booknumber='" + booknumber + "'";//删除语句
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();//执行语句
                //查询下是否还有该记录
                string chaxunsql = "select * from book where [booknumber]='" + txtchaxun.Text + "' or bookname like '%" +
                        txtchaxun.Text + "%' or bookwriter like '%" + txtchaxun.Text + "%' or bookfrom like '%" + txtchaxun.Text + "%'";
                SqlCommand chaxuncom = new SqlCommand(chaxunsql, con);
                SqlDataReader chaxundb = chaxuncom.ExecuteReader();//执行语句
                if (chaxundb.Read())
                {
                    Response.Write("<script>alert('该记录还存在，未删除')</script>");
                }
                else
                {
                    LabelShow.Text = "";//清空显示框
                    LabelShow.Text = "该图书已被删除";
                }
                chaxundb.Close();
                con.Close();
            }
            
        }

        protected void btnchaxun_Click(object sender, EventArgs e)
        {
            //查询图书
            //判断查询框是否为空
            if (txtchaxun.Text == "")
            {
                Response.Write("<script>alert('文本框为空，请先输入值')</script>");
            }
            else
            {
                //查询
                
                con.Open();//打开数据库
                string sql = "select * from book where booknumber='" + txtchaxun.Text + "' or bookname like '%" +
                    txtchaxun.Text + "%' or bookwriter like '%" + txtchaxun.Text + "%' or bookfrom like '%" + txtchaxun.Text + "%'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader db = com.ExecuteReader();//执行语句
                //陆续读数据
                if (db.Read())
                {
                    //结果显示
                    booknumber = db[0].ToString();//图书编号
                    LabelShow.Text = db[0].ToString() + " " + db["bookname"].ToString() + " " + db["bookfrom"].ToString() + " " +
                        db["bookwriter"].ToString() + " " + db["bookm"].ToString() + " " + db["bookstatus"].ToString();
                    db.Close();
                    con.Close();//关闭
                    Response.Write("<script>alert('查询成功')</script>");

                }
                else
                {
                    LabelShow.Text = "未查到该图书";

                }

            }
        }

        protected void Buttonadd_Click(object sender, EventArgs e)
        {
            string number = TextBoxno.Text.Trim();
            string name = TextBoxname.Text.Trim();
            string writer = TextBoxw.Text.Trim();
            string from = TextBoxfrom.Text.Trim();
            string m= TextBoxm.Text.Trim();
            //判断文本框不为空
            if (number == "" || name == "" || writer == "" || from == "" || m == "")
            {
                Response.Write("<script>alert('文本框为空，请输入')</script>");
                
            }
            else {
                
                //添加图书
 
                con.Open();//打开数据库
                //先查询图书表中是否有该书
                string chaxunsql = "select * from book where booknumber='" + number + "' or (bookname='" +
                        name + "' and bookwriter='" + writer + "' and bookfrom='" + from + "')";
                SqlCommand chaxuncom = new SqlCommand(chaxunsql, con);
                SqlDataReader chaxundb = chaxuncom.ExecuteReader();//执行语句
                //陆续读数据
                if (chaxundb.Read())
                {
                    //如果查到存在记录
                    if (chaxundb["booknumber"].ToString() == number)
                    {
                        //如果书编号相同
                        Response.Write("<script>alert('该图书编号已存在!')</script>");
                    }
                    else if (chaxundb[1].ToString() == name && chaxundb[2].ToString() == from && chaxundb[3].ToString() == writer)
                    {
                        //书编号不同，书名+作者+出版社 三个相同
                        Response.Write("<script>alert('该图书已存在!')</script>");
                    }
                    chaxundb.Close();
                    con.Close();
                }
                else
                {
                    chaxundb.Close();
                    //添加
                    string sql = "insert into book values('" + number + "','" + name + "','" + from + "','" + writer + "','" + m + "','0')";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();//执行语句
                    con.Close();
                    Response.Write("<script>alert('添加成功')</script>");

                }
                
               
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //清空
            TextBoxno.Text="";
            TextBoxname.Text="";
            TextBoxw.Text="";
            TextBoxfrom.Text="";
            TextBoxm.Text = "";
        }

        protected void btnsuoyou_Click(object sender, EventArgs e)
        {
            //查询所有图书
            GridView1.Visible = true;//可见
            
        }
    }
}