using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HidenIntelligence.Areas.Admin.Models;

namespace HidenIntelligence
{
    public class CartController : Controller
    {
        private Model1 context = new Model1();
        //
        // GET: /Cart/

        public ActionResult Index1()
        {
            var cart = (Cart)Session["CartSession"];
            if (cart ==null) {
                cart = new Cart();
            }

            return View(cart);
        }



        public ActionResult AddItem(int id, string returnURL)
        {   var product = context.SanPhams.Find(id);
            var cart = (Cart)Session["CartSession"];
            if (cart != null) {
                cart.AddItem(product, 1);
                //Gán vào session
                Session["CartSession"] = cart;
            }
            else {
                //tạo mới đối tượng cart item
                cart = new Cart();
                cart.AddItem(product, 1);
                //Gán vào session
                Session["CartSession"] = cart;
            }

            if (string.IsNullOrEmpty(returnURL)) {
                return RedirectToAction("Index1");
            }
            return Redirect(returnURL);
        }

        //

        // GET: /Cart/Details/5
        public ActionResult RemoveLine(int id)
        {

            var product = context.SanPhams.Find(id);

            var cart = (Cart)Session["CartSession"];

            if (cart != null)  {
                cart.RemoveLine(product);
                //Gán vào session
                Session["CartSession"] = cart;
            }
            return RedirectToAction("Index1");
        }

        public ActionResult UpdateCart(int[] masp, int[] qty)
        {
            var cart = (Cart)Session["CartSession"];

            if (cart != null)
            {
                for (int i = 0; i < masp.Count(); i++)
                {
                    //var tmp = masp[i];
                    //var product = context.SanPhams.Where(x => x.MaSP == tmp).FirstOrDefault();
                    var product = context.SanPhams.Find(masp[i]);
                    cart.UpdateItem(product, qty[i]);
                }

                Session["CartSession"] = cart;
            }

            return RedirectToAction("Index1");

        }


        //
        // GET: /Cart/Details/5
        //[HttpGet]
        //public ActionResult Payment()
        //{
        //    var cart = (Cart)Session["CartSession"];
        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //    }
        //    return View(cart);
        //}

        //[HttpPost]
        //public ActionResult Payment(HoaDon model)
        //{
        //    model.NgayHD = DateTime.Now;
        //    try {
        //        context.HoaDons.Add(model);
        //        context.SaveChanges();
        //        var cart = (Cart)Session["CartSession"];           
        //        foreach (var item in cart.Lines) {
        //            ChiTietHD obj = new ChiTietHD();
        //            obj.MaHD = model.MaHD;
        //            obj.MaSP = item.Sanpham.MaSP;
        //            obj.DonGia = item.Sanpham.GiaSP;
        //            obj.SoLuong = item.Quantity;

        //            context.ChiTietHDs.Add(obj);
        //            context.SaveChanges();                  
        //        }
        //        cart.Clear();
        //        Session["CartSession"] = cart;
        //    }
        //    catch (Exception ex)  {
        //        //ghi log
        //        return RedirectToAction("/Loi");
        //    }
        //    return View("Complete");
        //}

        //
        // GET: /Cart/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cart/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cart/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cart/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cart/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cart/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult thank()
        {
            return View();
        }
        [HttpPost]
        public ActionResult xacnhan(KhachHang model)
        {
            context.KhachHangs.Add(model);
            context.SaveChanges();
            return View("thank");
        }
    }
}
