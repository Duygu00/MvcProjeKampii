using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvcprojekampi.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik

        Context c = new Context();
        public ActionResult Index()
        {
            var deger1 = c.Categories.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Headings.Count(x=>x.HeadingName=="Yazılım").ToString();
            ViewBag.d2 = deger2;
            var deger3 = c.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.d3 = deger3;
            var deger4 = c.Headings.Max(x => x.Category.CategoryName);
            ViewBag.d4 = deger4;
            var deger5 = c.Categories.Count(x => x.CategoryStatus== true);
            ViewBag.d5 = deger5;
            var deger6 = c.Categories.Count(x => x.CategoryStatus==false);
            ViewBag.d6 = deger6;
            int top = deger5 - deger6;
            ViewBag.d7 = top;
            var deger8 = c.Headings.Count().ToString();
            ViewBag.d8 = deger8;
            return View();
            
        }
    }
}