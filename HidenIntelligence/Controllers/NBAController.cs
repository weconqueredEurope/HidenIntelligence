using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class NBAController : Controller
    {
        Model1 db = new Model1();
        // GET: NBA
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 45 || x.MaLoai == 46 || x.MaLoai == 47 || x.MaLoai == 48 || x.MaLoai == 49 ||
            x.MaLoai == 50).ToList();
            return View(model);
        }
    }
}