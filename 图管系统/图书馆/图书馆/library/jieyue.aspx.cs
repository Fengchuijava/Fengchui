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
    public partial class jieyue : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
        public static string username;
                
        protected void Page_Load(object sender, EventArgs e)
        {
            //先清空
            LabelShow.Text = "";
            txtnumber.Text = "";
            txtname.Text = "";
            txtwriter.Text = "";
            txtfrom.Text = "";

            if ((Session["userid"] == null) || (Session["password"] == null))
            {
                //如果为空
                //Console.Write("为空");
            }
            else
            {
                //获取当前登录的用户名和密码值

                username = Session["userid"].ToString();
                //pwd = Session["password"].ToString();

            }
        }



        protected void btnjieyue_Click(object sender, EventArgs e)
        {
            //借阅按钮

            string jieyuenumber = txtnumber.Text.Trim();
            string jieyuename = txtname.Text.Trim();
            string jieyuewriter = txtwriter.Text.Trim();
            string jieyuefrom = txtfrom.Text.Trim();

            //数据库连接字符串
           
            //判断输入框是否为空
            //只输入图书编号 或者 名称+作者+出版社 其中一种
            if (jieyuenumber == "" && (jieyuename != "" && jieyuewriter != "" && jieyuefrom != ""))
            {
                //文本框两者中至少输入一者
                Response.Write("<script>alert('文本框为空，请至少输入一者')</script>");
            }else if(jieyuenumber!="" && (jieyuename=="" && jieyuewriter=="" &&jieyuefrom=="")){
                 Response.Write("<script>alert('文本框为空，请至少输入一者')</script>");
            
            }
            else{
                con.Open();//打开数据库
                //查询其要借阅图书的借阅状态
                 
                string sql = "select * from book where booknumber='" + jieyuenumber + "' or (bookname like '%" +
                    jieyuename + "%' and bookwriter like '%" + jieyuewriter + "%' and bookfrom like '%" + jieyuefrom + "%')";

                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader db = com.ExecuteReader();//执行语句
                //陆续读数据
                if (db.Read())
                {                             
                    if (db["bookstatus"].ToString()=="0")
                    {
                        //如果借阅状态为0（未借）
                        string stuname =db[1].ToString();//借阅书的书名先放进stuname
                        string stunumber =db[0].ToString();//借阅书的书号先放进stuno
                        db.Close();//先关闭db,在执行
                        //string username = Session["userid"].ToString();//借阅人的用户名
                        string updatesql = "update book set bookstatus='1' where booknumber='" + stunumber + "' and bookname='"+stuname+"'";//修改借阅状态为1（已借）
                        SqlCommand updatecom = new SqlCommand(updatesql, con);
                        updatecom.ExecuteNonQuery();//执行更新

                       
                        //添加书信息到借阅表
                        string insertsql = "insert into bookj(booknumber,username,status) values('" + stunumber + "','" + username + "',0) ";
                       
                        SqlCommand insertcom = new SqlCommand(insertsql, con);
                        insertcom.ExecuteNonQuery();//执行添加

                        //显示借阅书籍的相关信息
                        string selectsql = "select bookj.stuno,bookj.username,book.* from book,bookj where book.booknumber=bookj.booknumber and (book.booknumber='"+stunumber+"'and status=0 )";
                        SqlCommand selectcom = new SqlCommand(selectsql,con);
                        SqlDataReader read = selectcom.ExecuteReader();//执行语句
                        if (read.Read())
                        {
                            LabelShow.Text = "";
                            LabelShow.Text = read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString() + " " + read[3].ToString() + " " +
                                read[4].ToString() + " " + read[5].ToString() + " " + read[6].ToString() + " " + read[7].ToString() + " ";
                        }
                        read.Close();
                        read.Dispose();
                    }
                    else
                    {
                        LabelShow.Text = "";
                        LabelShow.Text = "该书已经借出，请借阅其他书籍";

                    }

                }
                else
                {
                    Response.Write("<script>alert('未查询到该书')</script>");

                }
               
            
            }
            con.Close(); 
               

         }

        
       
    }
}