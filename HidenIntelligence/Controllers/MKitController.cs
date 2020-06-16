using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class MKitController : Controller
    {
        Model1 db = new Model1();
        // GET: ModuleKit
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 1 ||  x.MaLoai == 2 || x.MaLoai == 3 || x.MaLoai == 4 || x.MaLoai == 5 ||
            x.MaLoai == 6).ToList();
            return View(model);
        }
    }
}