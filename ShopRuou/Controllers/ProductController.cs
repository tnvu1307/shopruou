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

        public ActionResult SanPhamNSX(int? id, int curPage = 1)
        {
            if(id.HasValue == false)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var ctx = new QLShopRuouEntities())
            {
                List<chitietSP> list;
                var query = ctx.chitietSPs.Where(c => c.sanpham.maNSX == id);
                ViewBag.tenNSX = ctx.nhasanxuats.Where(c => c.maNSX == id).Select(c => c.tenNSX).FirstOrDefault();
                //dem so luong trang
                int n = query.Count();
                int nPages = n / 4;
                if (n % 4 > 0) nPages++;
                ViewBag.nPages = nPages;
                ViewBag.curPage = curPage;
                ViewBag.nextPage = curPage + 1;
                ViewBag.prevPage = curPage - 1;
                if(n == 0)
                {
                    ViewBag.sl = 0;
                }
                //
                int nSkip = (curPage - 1)*4;
                list = query.OrderBy(c=> c.maSP)
                    .Skip(nSkip).Take(4)
                    .ToList();
                return View(list);
            }
        }

        public ActionResult SanPhamDM(int? id, int curPage = 1)
        {
            if (id.HasValue == false)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var ctx = new QLShopRuouEntities())
            {
                List<chitietSP> list;
                var query= ctx.chitietSPs.Where(c => c.sanpham.maloaiSP == id).ToList();
                ViewBag.tenloaiSP = ctx.loaiSPs.Where(c => c.maloaiSP == id).Select(c => c.tenloaiSP).FirstOrDefault();
                int n = query.Count();
                int nPages = n / 4;
                if (n % 4 > 0) nPages++;
                ViewBag.nPages = nPages;
                ViewBag.curPage = curPage;
                ViewBag.nextPage = curPage + 1;
                ViewBag.prevPage = curPage - 1;
                if (n == 0)
                {
                    ViewBag.sl = 0;
                }
                int nSkip = (curPage - 1) * 4;
                list = query.OrderBy(c => c.maSP)
                    .Skip(nSkip).Take(4)
                    .ToList();
                return View(list);
            }
        }

        public ActionResult chitietSP(int? id)
        {
            if(id.HasValue == false)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.maSP = id;
            return View();
        }
    }
}