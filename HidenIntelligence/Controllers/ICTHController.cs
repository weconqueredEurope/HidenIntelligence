using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class ICTHController : Controller
    {
        Model1 db = new Model1();
        // GET: ICTH
        public ActionResult Index()
        {
            var model = db.SanPhams.Where(x => x.MaLoai == 20 || x.MaLoai == 24 || x.MaLoai == 21 || x.MaLoai == 22 || x.MaLoai == 23).ToList();
            return View(model);
        }
    }
}