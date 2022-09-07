using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bloglarproje.Models.siniflar;

namespace Bloglarproje.Controllers
{
    public class AboutController : Controller

    {
        Context c = new Context();

        // GET: About
        public ActionResult Index()
        {
            var degerler = c.hakkimizdas.ToList();
            return View(degerler);
        }
    }
}