using ShopRuou.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopRuou.Helpers
{
    public class CurrentContext
    {
        public static bool Islogged()
        {
            if ((int)HttpContext.Current.Session["IsLogin"] == 1)
                return true;
            if (HttpContext.Current.Response.Cookies["Username"] != null)
            {
                string username = HttpContext.Current.Response.Cookies["Username"].Value;
                
                using (QLShopRuouEntities ctx = new QLShopRuouEntities())
                {
                    taikhoan user = ctx.taikhoans.Where(t => t.tk == username).FirstOrDefault();
                    if (user != null)
                    {
                        HttpContext.Current.Session["IsLogin"] = 1;
                        HttpContext.Current.Session["CurUser"] = user;
                        return true;
                    }
                }
                
            }
            return false;
        }

        public static taikhoan CurUser()
        {
            return (taikhoan)HttpContext.Current.Session["CurUser"];
        }

        public static void Destroy()
        {
            HttpContext.Current.Session["IsLogin"] = 0;
            HttpContext.Current.Session["CurUser"] = null;

            HttpContext.Current.Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}