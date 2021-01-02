using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace 图书馆.library
{
    public partial class jiansuo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnchaxun_Click(object sender, EventArgs e)
        {
            //查询

            //判断查询框是否为空
            if (txtchaxun.Text =="")
            {
                Response.Write("<script>alert('文本框为空，请先输入值')</script>");
            }
            else {
                //查询
               
                con.Open();//打开数据库
                string sql = "select * from book where [booknumber]='" + txtchaxun.Text + "' or [bookname] like '%" +
                    txtchaxun.Text + "%' or [bookwriter] like '%" + txtchaxun.Text + "%' or [bookfrom] like '%" + txtchaxun.Text + "%'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader db = com.ExecuteReader();//执行语句
                /*
                OleDbDataAdapter db = new OleDbDataAdapter(com);
                DataSet ds = new DataSet();
                db.Fill(ds);
                DataTable dt = ds.Tables[0];//将ds中第一张表赋给dt
                 */
                //陆续读数据
                if (db.Read())
                {
                    //结果显示
                  
                    LabelShow.Text = db[0].ToString() + " " + db["bookname"].ToString() + " " + db["bookfrom"].ToString() + " " +
                        db["bookwriter"].ToString() + " " + db["bookm"].ToString() + " " + db["bookstatus"].ToString();

                    /*
                    GridView1.DataSource = db;
                    GridView1.DataBind();
                   
                     */ 
                    

                    Response.Write("<script>alert('查询成功')</script>");
                    
                    
                    

                }
                else
                {
                    LabelShow.Text = "未查到该图书";

                }
                db.Close();
                con.Close();//关闭
            
            }

        }

        protected void Buttonchaxun_Click(object sender, EventArgs e)
        {
            //查询图书的借阅编号
            con.Open();
            string sql = "select stuno from bookj,book where (bookj.booknumber='" + txtchaxun.Text + "' and status=0 ) or (book.bookname='" + txtchaxun.Text + "' and status=0 ) and book.booknumber=bookj.booknumber";
            SqlCommand com = new SqlCommand(sql,con);
            SqlDataReader read = com.ExecuteReader();
            if (read.Read())
            {
                Labelxianshi.Text = read[0].ToString();
            }
            else {
                Labelxianshi.Text = "无借阅编号";
            
            }
        }
    }
}