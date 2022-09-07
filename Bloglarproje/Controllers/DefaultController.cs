using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bloglarproje.Models.siniflar;

namespace Bloglarproje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index(){
            var degerler = c.blogs.ToList();
        
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}