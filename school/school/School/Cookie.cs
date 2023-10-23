using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace school.School
{
    abstract class Cookies
    {
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
            HttpContext.Current.Response.AppendCookie(cookie);

        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="key">键名</param>
        /// <param name="strValue">值</param>
        public static void Write(string strName, string key, string strValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie[key] = strValue;
            HttpContext.Current.Response.AppendCookie(cookie);

        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        /// <param name="strValue">过期时间(分钟)</param>
        // public static void Write(string strName, string strValue, int expires)
        // {
        //     HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
        //     if (cookie == null)
        //     {
        //         cookie = new HttpCookie(strName);
        //     }

        //     cookie.Value = strValue;
        ////     cookie.Secure = true;


        //     cookie.Expires = System.DateTime.Now.AddMinutes(expires);
        //     HttpContext.Current.Response.AppendCookie(cookie);
        // }

        /// <summary>

        /// 写cookie值

        /// </summary>

        /// <param name="strName">名称</param>

        /// <param name="strValue">值</param>

        /// <param name="strValue">过期时间(分钟)</param>

        public static void Write(string strName, string strValue, int expires)
       {
    
          HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
          


            if (cookie == null )

            {

                cookie = new HttpCookie(strName);

            }
        
            cookie.Secure = true;
            cookie.Value = strValue;
         
            cookie.Expires = System.DateTime.Now.AddMinutes(expires);
            HttpContext.Current.Response.AppendCookie(cookie);



        }

        

/// <summary>
/// 读cookie值
/// </summary>
/// <param name="strName">名称</param>
/// <returns>cookie值</returns>
public static string Read(string strName)
      {
       
            HttpCookie Cookie = HttpContext.Current.Request.Cookies[strName];
        if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null)
        {
            return HttpContext.Current.Request.Cookies[strName].Value;
        }
        else
        {
            return string.Empty;
        }
    }
    public static string GetCookie(string strName)
    {

        HttpCookie Cookie = HttpContext.Current.Request.Cookies[strName];
        if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null)
        {
            return HttpContext.Current.Request.Cookies[strName].Value.ToString();
        }
        return "";

    }


  



}
    }
