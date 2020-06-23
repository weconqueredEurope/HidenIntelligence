using HidenIntelligence.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidenIntelligence.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            var model = db.SanPhams.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Index(string search)
        {
            var result = db.SanPhams.Where(x => x.TenSP.Contains(search)).ToList();
            if (result.Count > 0)
            {
                return View("SearchResult", result);
            }
            else
            {
                return View(db.SanPhams.ToList());
            }
        }

        //search view
        public ActionResult SearchResult()
        {
            return View();
        }

        public ActionResult TermsAndPolicy()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult FAQS()
        {
            return View();
        }

        public ActionResult Product(int id)
        {
            var model = db.SanPhams.Find(id);
            return View(model);
        }

        //Category
        [ChildActionOnly]
        public ActionResult Category()
        {
            var model = db.TheLoaiSPs.Where(x => x.MaLoai >= 100).ToList();
            return PartialView(model);
        }
        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult payment()
        {
            return View();
        }

    }
}