using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class LKBDController : Controller
    {
        // GET: LKBD
        Model1 db = new Model1();
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 7 || x.MaLoai == 8 || x.MaLoai == 9 || x.MaLoai == 10 || x.MaLoai == 11 ||
            x.MaLoai == 12).ToList();
            return View(model);
        }
    }
}