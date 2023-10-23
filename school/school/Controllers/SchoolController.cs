using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CenterControl;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using school.School;
using school.Models;


namespace school.Controllers
{
   
    public class CookieHelper
    {
        #region 读cookie值

        /// <summary>
        /// 读cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <returns>cookie值</returns>
        public static string Read(string strName)
        {
            if (HttpContext.Current.Request.Cookies != null
                && HttpContext.Current.Request.Cookies[strName] != null)
            {
                return HttpContext.Current.Request.Cookies[strName].Value;
            }
            else
            {
                return string.Empty;
            }
        }
        #endregion
        #region 写cookie值
        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void Write(string strName, string strValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = strValue;

            cookie.Value = HttpUtility.UrlEncode(strValue, HttpContext.Current.Response.ContentEncoding);
            HttpContext.Current.Response.AppendCookie(cookie);

        }
        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        /// <param name="strValue">过期时间(分钟)</param>
        public static void Write(string strName, string strValue, int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }

            cookie.Value = strValue;
            cookie.Expires = System.DateTime.Now.AddMinutes(9999999);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        #endregion
    }



    public class SchoolController : Controller
    {

        User a = new User();
        public ActionResult index()
        {
            return View();
        }
        //登录界面
        public ActionResult login()
        {
            return View();
        }
        public ActionResult loginabc(FormCollection F)
        {
            string uname = F["username"];
            string upass = F["password"];
            //  string r = F["cookie"];
            string sql = "SELECT *  FROM Users WHERE uname='" + uname + "' and upass='" + upass + "'";
            DataSet b = SqlHelp.Query(sql);
            if (b != null && b.Tables[0].Rows.Count > 0)
            {

                CookieHelper.Write("username", uname);
                CookieHelper.Write("userpassword", upass);
                Response.Write("<script>alert('登录成功');</script>");
                return View("index");
            }
            else
            {
                Response.Write("<script>alert('登录失败');</script>");
                return View("Login");

            }
        }
        //栏目
        public ActionResult billAdd()
        {
            return View();
        }
        public ActionResult lm(FormCollection F)
        {
            string title = F["title"];
            string lm = F["supplier"];
            string c = "SELECT [title] FROM [School-zs].[dbo].[Release] where title='" + title + "'";
            DataSet B = SqlHelp.Query(c);
            if (B != null && B.Tables[0].Rows.Count > 0)
            {
                Response.Write("<script>alert('标题重复');</script>");
                return View("billAdd");
            }
            else
            {
                string sql = "INSERT INTO [School-zs].[dbo].[Release] ([title],[colum]) VALUES ('" + title + "', '" + lm + "')";
                SqlHelp.ExecuteSql(sql);
                Response.Write("<script>alert('保存成功');</script>");
                return View("billAdd");
            }
        }
        public ActionResult billList()
        {
            return View();
        }
        public ActionResult billUpdate()
        {
            return View();
        }
        public ActionResult billView()
        {
            return View();
        }
        public ActionResult password()
        {
            return View();
        }
        // 发布文章
        public ActionResult providerAdd()
        {

            string x = "SELECT [title] FROM [School-zs].[dbo].[Release]";
            DataTable b = SqlHelp.Query(x).Tables[0];
            List<User> ls = new List<User>();

            foreach (DataRow d in b.Rows)
            {
                a = new User();
                a.titl = d["title"].ToString();
                ls.Add(a);
            }
            ViewBag.Show = ls;
            return View();
        }
        //[ValidateInput(false)]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Articles(FormCollection F, string value)
        {
            User a = new User();
            string x = "SELECT [title] FROM [School-zs].[dbo].[Release]";
            DataTable b = SqlHelp.Query(x).Tables[0];



            List<User> ls = new List<User>();

            foreach (DataRow d in b.Rows)
            {
                a = new User();
                a.titl = d["title"].ToString();
                ls.Add(a);
            }
            ViewBag.Show = ls;
            string title = F["providerId"];
            string colum = F["supplier"];
            string source = F["people"];
            string zz = CookieHelper.Read("username");
            string content = F["conten"];
            string datatime = DateTime.Now.ToString();
            string sql = "INSERT INTO [School-zs].[dbo].[Articles] ([title],[colum] ,[source] ,[publishe]  ,[conten],[date]) VALUES('" + title + "','" + colum + "','" + source + "','" + zz + "','" + content + "','" + datatime + "')";
            SqlHelp.ExecuteSql(sql);
            //Response.Write("<script>alert('成功');</script>");
            //return View("providerAdd");
            return Content("<script language='javascript' type='text/javascript'>alert(' 成功 ');window.location.href='/School/providerAdd';</script>");
        }

        //文章显示
        public ActionResult providerList()
        {
            string sql = "SELECT [aid], [title] ,[colum] ,[source] ,[publishe] ,[conten] ,[date] FROM [Articles]";
            DataTable b = SqlHelp.Query(sql).Tables[0];
            List<User> ls = new List<User>();

            foreach (DataRow d in b.Rows)
            {
                a = new User();
                a.aid = Convert.ToInt32(d["aid"]);
                a.titl = d["title"].ToString();
                a.colum = d["colum"].ToString();
                a.source = d["source"].ToString();
                a.pubisher = d["publishe"].ToString();
                a.conten = d["conten"].ToString();
                a.date = Convert.ToDateTime(d["date"]);
                ls.Add(a);
            }
            ViewBag.Show = ls;
            return View("providerList");
        }
        //文章删除
        public ActionResult dele(string stuID)
        {
            User a = new User();
            string id = stuID;
            string sql = "DELETE FROM [School-zs].[dbo].[Articles] WHERE aid='" + id + "'";
            SqlHelp.Query(sql);
            Response.Write("<script>alert('删除成功');</script>");




            //string sq = "SELECT [aid], [title] ,[colum] ,[source] ,[publishe] ,[conten] ,[date] FROM [Articles]";
            //DataTable b = SqlHelp.Query(sq).Tables[0];
            //List<User> ls = new List<User>();

            //foreach (DataRow d in b.Rows)
            //{
            //    a = new User();
            //    a.aid = Convert.ToInt32(d["aid"]);
            //    a.titl = d["title"].ToString();
            //    a.colum = d["colum"].ToString();
            //    a.source = d["source"].ToString();
            //    a.pubisher = d["publishe"].ToString();
            //    a.conten = d["conten"].ToString();
            //    a.date = Convert.ToDateTime(d["date"]);
            //    ls.Add(a);
            //}
            //ViewBag.Show = ls;

            return View("providerList");

        }
        //文章修改

        public ActionResult providerUpdate()
        {

            return View();
        }
        public ActionResult providerView()
        {
            return View();
        }
        public ActionResult publics()
        {
            return View();
        }
        public ActionResult userAdd()
        {
            return View();
        }
        public ActionResult userList()
        {
            return View();
        }
        public ActionResult userUpdate()
        {
            return View();
        }
        public ActionResult userView()
        {
            return View();
        }
        public ActionResult Changepassword(FormCollection F)
        {
            string oldpass = F["oldPassword"];
            string newpass = F["reNewPassword"];
            string c = CookieHelper.Read("username");

            string sql = "UPDATE [School-zs].[dbo].[Users]  SET [upass] = '" + newpass + "' WHERE uname='" + c + "'  and upass='" + oldpass + "'";
            SqlHelp.ExecuteSql(sql);
            Response.Write("<script>alert('成功');</script>");
            return View("password");
        }
        //[HttpPost]
        public ActionResult p(string title, string colum, string soure, string pubisher, string content, string date)
        {
            ViewBag.title = title;
            ViewBag.colum = colum;
            ViewBag.soure = soure;
            ViewBag.pubisher = pubisher;
            ViewBag.content = content;
            ViewBag.date = date;
            return View("providerList");
        }
    }

}



    
