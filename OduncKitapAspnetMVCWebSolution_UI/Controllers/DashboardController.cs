using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OduncKitapAspnetMVCWebSolution_BLL.Managers;

namespace OduncKitapAspnetMVCWebSolution_UI.Controllers
{
    public class DashboardController : Controller
    {
        //global alan
        KitapManager myKitapManager = new KitapManager();
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.BugunEklenenKitapSayisi =
                myKitapManager.TumAktifKitaplariGetir()
                .Where(x=> x.KayitTarihi>DateTime.Now.AddDays(-1)
                &&
                 x.KayitTarihi < DateTime.Now.AddDays(1)
                )
                .Count();
            return View();
        }
    }
}