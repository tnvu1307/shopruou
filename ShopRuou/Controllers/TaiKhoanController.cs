using ShopRuou.Filters;
using ShopRuou.Helpers;
using ShopRuou.Models;
using System;
using System.Linq;
using System.Web.Mvc;
namespace ShopRuou.Controllers
{
    public class TaiKhoanController : Controller
    {
        //
        // GET: /TaiKhoan/
        public ActionResult Login()
        {
            if(CurrentContext.Islogged())
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //
        // POST: /TaiKhoan/Login
        [HttpPost]
        public ActionResult Login(Login u)
        { 
            using(QLShopRuouEntities ctx = new QLShopRuouEntities())
            {
                string umd5 = Helpers.StringUtils.Md5(u.pass);
                taikhoan user = ctx.taikhoans.Where(t => t.tk == u.user && t.matKhau == umd5).FirstOrDefault();
                if (user == null)
                {
                    ViewBag.error = "Thông tin đăng nhập không đúng";
                    return View(u);
                }
                else
                {
                    Session["IsLogin"] = 1;
                    Session["CurUser"] = user;
                    if(u.remember)
                    {
                        Response.Cookies["Username"].Value = user.tk;
                        Response.Cookies["Username"].Expires = DateTime.Now.AddDays(1);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        //
        // POST: /TaiKhoan/Logout
        [HttpPost]
        public ActionResult Logout()
        {
            CurrentContext.Destroy();
            return RedirectToAction("Index", "Home");
        }


        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(RegisterModel model)
        {
            taikhoan tk = new taikhoan{
                tk = model.UID,
                matKhau = Helpers.StringUtils.Md5(model.PWD),
                hoTen = model.Fullname,
                email = model.Email,
                ngaySinh = Convert.ToDateTime(model.Birthday),
                ltk = 2,
            };

            using (var ctx = new QLShopRuouEntities())
            {
                ctx.taikhoans.Add(tk);
                ctx.SaveChanges();
            }
            return View();
        }

        private string StringUtils()
        {
            throw new NotImplementedException();
        }

        [CheckLogin]
        public ActionResult TTtaikhoan()
        {
            return View();
        }
	}
}