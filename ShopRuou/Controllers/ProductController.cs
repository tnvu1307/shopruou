using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopRuou.Models;
namespace ShopRuou.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult partialnhaSX()
        {
            using (var ctx = new QLShopRuouEntities1())
            {
                List<nhasanxuat> list = ctx.nhasanxuats.OrderBy(c => c.tenNSX).ToList();
                return PartialView(list);
            }
        }
    }
}