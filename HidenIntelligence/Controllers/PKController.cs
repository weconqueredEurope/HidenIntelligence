using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class PKController : Controller
    {
        Model1 db = new Model1();
        // GET: PK
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 51 || x.MaLoai == 52 || x.MaLoai == 53 || x.MaLoai == 54 || x.MaLoai == 55
            || x.MaLoai == 56 || x.MaLoai == 57 || x.MaLoai == 58 || x.MaLoai == 59 || x.MaLoai == 60).ToList();
            return View(model);
        }
    }
}