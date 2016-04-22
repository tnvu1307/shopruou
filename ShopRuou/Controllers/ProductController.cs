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

        public ActionResult SanPhamNSX(int? maNSX)
        {
            if(maNSX.HasValue == false)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var ctx = new QLShopRuouEntities())
            {
                List<chitietSP> list = ctx.chitietSPs.Where(c => c.sanpham.maNSX == maNSX).ToList();
                if(list.Count == 0)
                {
                    ViewBag.sl = 0;
                }
                return View(list);
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