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
    public partial class huanshu : System.Web.UI.Page
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
       // string pwd;
        protected void Page_Load(object sender, EventArgs e)
        {
            
                if ((Session["userid"] == null) || (Session["password"] == null))
                {
                    //如果为空
                    //Console.Write("为空");
                }
                else
                {
                    //获取当前登录的用户名和密码值

                    name= Session["userid"].ToString();
                    //pwd = Session["password"].ToString();

                }
            
        }

        protected void btnjieyue_Click(object sender, EventArgs e)
        {
            //归还按钮
           //long sno = Convert.ToInt32(txtsno.Text);//借书编号
           //数据库连接字符串
           
           con.Open();//打开数据库

            //判断输入框是否为空
            //根据借书编号还自己的书
            //或者再次输入借阅人用户名帮别人还书
            if (txtsno.Text.Trim()!= "" && TextBoxname.Text.Trim()=="")
            {
                //只输入借阅编号，为自己还书

                //查询图书借阅表中的还书状态
                string sql = "select * from bookj where stuno=" + Convert.ToInt32(txtsno.Text) + " and username='"+name+"'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader db = com.ExecuteReader();//执行语句
                //陆续读数据
                if (db.Read())
                {

                    if (db["status"].ToString() == "0")
                    {
                        //如果还书状态为0（未还）

                        db.Close();//先关闭
                        //更新其还书状态为1，并追加还书用户
                        string updatesql = "update bookj set status='1',huanshuuser='"+name+"' where stuno=" + Convert.ToInt32(txtsno.Text) + " and username='"+name+"'";//修改状态为1（已还）
                        SqlCommand updatecom = new SqlCommand(updatesql, con);
                        updatecom.ExecuteNonQuery();//执行更新
                        
                        //修改书信息的借书状态
                        string usql = "update book set bookstatus='0' where booknumber=(select booknumber from bookj where stuno=" + Convert.ToInt32(txtsno.Text) + " and username='"+name+"')";
                        SqlCommand ucom = new SqlCommand(usql, con);
                        ucom.ExecuteNonQuery();//执行更新
                        //显示归还书籍的相关信息
                        string selectsql = "select bookj.*,bookname,bookwriter,bookfrom,bookstatus from book,bookj where book.booknumber=bookj.booknumber and stuno=" + Convert.ToInt32(txtsno.Text) +
                            "";
                        SqlCommand selectcom = new SqlCommand(selectsql, con);
                        SqlDataReader read = selectcom.ExecuteReader();//执行语句
                        if (read.Read())
                        {
                            LabelS.Text = read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString() + " " + read[3].ToString() + " " +
                                read[4].ToString() + " " + read[5].ToString() + " " + read[6].ToString() + " " + read[7].ToString();
                        }
                        read.Close();
                        /*
                        //书已还，就删掉借阅表中的记录
                        string deletesql = "delete from bookj where [stuno]=" + Convert.ToInt32(txtsno.Text) + " and [username]='"+name+"'";
                        SqlCommand deletecom = new SqlCommand(deletesql, con);
                        deletecom.ExecuteNonQuery();//执行删除
                         */ 
                        
                        Response.Write("<script>alert('归还成功')</script>");
                        
                        
                    }
                    else
                    {
                        LabelS.Text = "该书已被归还！";
                    }

                }
                else
                {
                    Response.Write("<script>alert('该用户并未借阅这本书！')</script>");

                }
                //db.Close();
                con.Close();//关闭

            }
            else if (txtsno.Text.Trim() != "" && TextBoxname.Text.Trim() != "")
            {
                //借阅编号+借阅人用户名：帮别人还书
                string hname = TextBoxname.Text.Trim();//借阅人用户名
                //查询图书借阅表中的还书状态
                string hsql = "select * from bookj where stuno=" + Convert.ToInt32(txtsno.Text) + " and username='" + hname + "'";
                SqlCommand hcom = new SqlCommand(hsql, con);
                SqlDataReader hdb = hcom.ExecuteReader();//执行语句
                //陆续读数据
                if (hdb.Read())
                {

                    if (hdb["status"].ToString() == "0")
                    {
                        //如果还书状态为0（未还）
                        hdb.Close();
                        //更新其还书状态为1，并追加还书用户
                        string updatesql = "update bookj set status='1',huanshuuser='"+name+"' where stuno=" + Convert.ToInt32(txtsno.Text) + " and username='" +hname + "'";//修改状态为1（已还）
                        SqlCommand updatecom = new SqlCommand(updatesql, con);
                        updatecom.ExecuteNonQuery();//执行更新
                        //修改书信息的借书状态
                        string usql = "update book set [bookstatus]='0' where [booknumber]=(select [booknumber] from bookj where [stuno]=" + Convert.ToInt32(txtsno.Text) + " and [username]='" + hname + "')";
                        SqlCommand ucom = new SqlCommand(usql, con);
                        ucom.ExecuteNonQuery();//执行更新
                        //显示归还书籍的相关信息
                        string selectsql = "select bookj.*,bookname,bookwriter,bookfrom,bookstatus from book,bookj where book.booknumber=bookj.booknumber and stuno=" + Convert.ToInt32(txtsno.Text) +
                            " and username='" + hname + "' ";
                        SqlCommand selectcom = new SqlCommand(selectsql, con);
                        SqlDataReader read = selectcom.ExecuteReader();//执行语句
                        if (read.Read())
                        {
                            LabelS.Text = read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString() + " " + read[3].ToString() + " " +
                                read[4].ToString() + " " + read[5].ToString() + " " + read[6].ToString() + " " + read[7].ToString()+" "+read[8].ToString();
                        }
                        read.Close();
                        /*
                        //书已还，就删掉借阅表中的记录
                        string deletesql = "delete from bookj where [stuno]=" + Convert.ToInt32(txtsno.Text) + "  and [username]='" + hname + "'";
                        SqlCommand deletecom = new SqlCommand(deletesql, con);
                        deletecom.ExecuteNonQuery();//执行删除
                         */ 
                        

                        Response.Write("<script>alert('归还成功')</script>");
                        
                    }
                    else
                    {
                        LabelS.Text = "该书已被归还！";
                    }

                }
                else
                {
                    Response.Write("<script>alert('该用户并未借阅这本书！')</script>");

                }
                //hdb.Close();
                con.Close();//关闭
            
            }
            else {

                Response.Write("<script>alert('文本框为空，请输入值！')</script>");
            }

        }
    }
}