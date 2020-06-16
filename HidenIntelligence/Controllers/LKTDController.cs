using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class LKTDController : Controller
    {
        Model1 db = new Model1();
        // GET: LKTD
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 25 || x.MaLoai == 26 || x.MaLoai == 27 || x.MaLoai == 28 || x.MaLoai == 29
            || x.MaLoai == 30 || x.MaLoai == 34 || x.MaLoai == 31 || x.MaLoai == 32 || x.MaLoai == 33 || x.MaLoai == 35).ToList();
            return View(model);
        }
    }
}