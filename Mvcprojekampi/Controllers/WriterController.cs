using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvcprojekampi.Controllers
{
    public class WriterController : Controller
    {
        WriterManager vm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var Writervalues = vm.GetList();
            return View(Writervalues);
        }
    }
}