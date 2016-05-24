using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopRuou.Helpers;

namespace ShopRuou.Filters
{
    public class CheckLoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (CurrentContext.Islogged() == false)
            {
                string controller = filterContext.RouteData.Values["controller"].ToString();
                string action = filterContext.RouteData.Values["action"].ToString();
                filterContext.Result = new RedirectResult(string.Format("~/TaiKhoan/Login?retUrl=/{0}/{1}", controller, action));
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}