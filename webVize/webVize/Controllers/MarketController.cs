using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVize.Controllers
{
    public class MarketController : Controller
    {
        // GET: Market
        public ActionResult Liste()
        {
            return View(Models.Market.MarketListesi);
        }

        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Market veri)
        {
            Models.Market.MarketListesi.Add(veri);
            return RedirectToAction("Liste");

        }

            public ActionResult Edit(int Id)
        {
            var d1 = Models.Market.MarketListesi.Where(e => e.Id == Id).FirstOrDefault();
            return View(d1);
        }

        [HttpPost]
        public ActionResult Edit(Models.Market d2)
        {
            var d1 = Models.Market.MarketListesi.Where(e => e.Id == d2.Id).FirstOrDefault();
            d1.Id = d2.Id;
            d1.Ad = d2.Ad;
            d1.Fiyat = d2.Fiyat;
            return RedirectToAction("Liste");
        }

        public ActionResult Delete(int Id)

        {

            var g3 = Models.Market.MarketListesi.Where(x => x.Id == Id).FirstOrDefault();

            return View(g3);

        }

        [HttpPost]
        public ActionResult Delete(Models.Market h44)

        {

            var h4 = Models.Market.MarketListesi.Where(x => x.Id == h44.Id).FirstOrDefault();
            Models.Market.MarketListesi.Remove(h4);
            return RedirectToAction("Liste");

        }

    }
}