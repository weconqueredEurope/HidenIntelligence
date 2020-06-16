using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class TBDCDController : Controller
    {
        Model1 db = new Model1();
        // GET: TBDCD
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 40 || x.MaLoai == 44 || x.MaLoai == 41 || x.MaLoai == 42 || x.MaLoai == 43).ToList();
            return View(model);
        }
    }
}