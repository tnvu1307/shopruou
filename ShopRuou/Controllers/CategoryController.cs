using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopRuou.Models;
namespace ShopRuou.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult partialloaiSP()
        {
            using(var ctx = new QLShopRuouEntities())
            {
                List<loaiSP> list = ctx.loaiSPs.OrderBy(c => c.tenloaiSP).ToList();
                return PartialView(list);
            }
        }
        public ActionResult partialnhaSX()
        {
            using (var ctx = new QLShopRuouEntities())
            {
                List<nhasanxuat> list = ctx.nhasanxuats.OrderBy(c => c.tenNSX).ToList();
                return PartialView(list);
            }
        }
    }
}