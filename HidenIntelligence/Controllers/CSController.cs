using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class CSController : Controller
    {
        Model1 db = new Model1();
        // GET: CS
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 36 || x.MaLoai == 37 || x.MaLoai == 38 || x.MaLoai == 39 ).ToList();
            return View(model);
        }
    }
}