using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class CBController : Controller
    {
        Model1 db = new Model1();
        // GET: CB
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 13 || x.MaLoai == 14 || x.MaLoai == 15 || x.MaLoai == 16 || x.MaLoai == 17 ||
            x.MaLoai == 18 || x.MaLoai == 19).ToList();
            return View(model);
        }
    }
}