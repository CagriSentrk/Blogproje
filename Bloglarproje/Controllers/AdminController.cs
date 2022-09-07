using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bloglarproje.Models.siniflar;
namespace Bloglarproje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]

        public ActionResult Index()
      
        {
            var degerler = c.blogs.ToList();
            return View(degerler);
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
        public ActionResult Blogsil(int id)
        {
            var b = c.blogs.Find(id);
            c.blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("index");

        }
        public ActionResult BlogGetir(int id)
        {
            var blog = c.blogs.Find(id);
            return View("BlogGetir", blog);
        }
        public ActionResult BlogGuncelle(blog b)
        {
            var blg = c.blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult Yorumsil(int id)
        {
            var b = c.yorumlars.Find(id);
            c.yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

    }
}