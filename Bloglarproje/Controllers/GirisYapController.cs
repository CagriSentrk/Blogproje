using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Bloglarproje.Models.siniflar;

namespace Bloglarproje.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c = new Context();
    
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullanici == ad.kullanici &&
            x.sifre == ad.sifre);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullanici, false);
                Session["kullanici"] = bilgiler.kullanici.ToString();
                return RedirectToAction("index", "Admin");
            }
            else
            {
                return View();
            }
           
        } 
        public ActionResult LogOut()
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Login", "GirisYap");
            }

    }
}