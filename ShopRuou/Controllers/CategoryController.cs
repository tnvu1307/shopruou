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

        public ActionResult SanPhamDM(int? maloaiSP)
        {
            if (maloaiSP.HasValue == false)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var ctx = new QLShopRuouEntities())
            {
                List<chitietSP> list = ctx.chitietSPs.Where(c => c.sanpham.maloaiSP == maloaiSP).ToList();
                if (list.Count == 0)
                {
                    ViewBag.sl = 0;
                }
                return View(list);
            }
        }

        public ActionResult partialloaiSP()
        {
            using(var ctx = new QLShopRuouEntities())
            {
                List<loaiSP> list = ctx.loaiSPs.OrderBy(c => c.tenloaiSP).ToList();
                return PartialView(list);
            }
        }
    }
}