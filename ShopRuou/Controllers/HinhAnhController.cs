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

        public ActionResult PartialBanner()
        {
            using (var c = new QLShopRuouEntities())
            {
                List<hinhanh> list = c.hinhanhs.ToList();
                return PartialView(list);
            }
        }
	}
}