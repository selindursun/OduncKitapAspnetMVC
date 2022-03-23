using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OduncKitapAspnetMVCWebSolution_BLL;
using OduncKitapAspnetMVCWebSolution_BLL.Managers;

namespace OduncKitapAspnetMVCWebSolution_UI.Controllers
{
    public class TurController : Controller
    {
        //global alan
        TurManager myTurManager = new TurManager();
        // GET: Tur
        public ActionResult Index()
        {
            //tüm türler gelecek
            try
            {
                List<Turler> turlist = myTurManager.AktifTumTurleriGetir();
                ViewBag.TurListCount = 0;
                if (turlist.Count>0)
                {
                    ViewBag.TurListCount = turlist.Count;
                }
                return View(turlist);
            }
            catch (Exception ex)
            {
            }
            return View();
        }

    }
}