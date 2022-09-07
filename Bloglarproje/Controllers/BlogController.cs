using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bloglarproje.Models.siniflar;

namespace Bloglarproje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        // GET: Blog
        public ActionResult Index()

        {
            // var bloglar = c.blogs.ToList();
            by.Deger1 = c.blogs.OrderByDescending(x => x.ID).Take(100).ToList();
            by.Deger3 = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }
        Blogyorum by = new Blogyorum();

        public ActionResult BlogDetay(int id)
        {

            // var blogbul = c.blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }



        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();

        }
    
       
    }
}