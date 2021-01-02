using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace 图书馆.userlogin
{
    /// <summary>
    /// zhuxiao 的摘要说明
    /// </summary>
    public class zhuxiao : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Session.Clear();//清空会话
            context.Session.Abandon();//取消当前会话
            //然后在跳转到登录界面
            context.Response.Redirect("./login.aspx");

            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}