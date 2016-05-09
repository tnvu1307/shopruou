using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopRuou.Models;
namespace ShopRuou.Controllers
{
    public class HinhAnhController : Controller
    {
        //
        // GET: /HinhAnh/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult banner()
        {
            using (var ctx = new QLShopRuouEntities())
            {
                List<hinhanh> list;
                var a= ctx.hinhanhs.ToList();
                list = a;
                return View(list);
            }
        }
	}
}