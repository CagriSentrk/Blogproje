using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bloglarproje.Models.siniflar;
namespace Bloglarproje.Controllers
{
    public class KullaniciController : Controller
        
    {
        Context c = new Context();
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(blog p)
        {
            c.blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("index");
        }


    }
}