using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OduncKitapAspnetMVCWebSolution_BLL.Managers;
namespace OduncKitapAspnetMVCWebSolution_UI.Controllers
{
    public class PartialsController : Controller
    {
        //global alan
        KitapManager myKitapManager = new KitapManager();
        //Partiallar kısmi görünüm anlamına gelmektedir.
        //Controller içinde partiallar oluşturulabilir.
        //Tüm Partial'ları tek bir yerden yönetmek amacıyla
        //biz PartialsController oluşturduk.
        //Fakat tabiki mevcutta var olan controllerların içine de partial oluşturabilir.
        public PartialViewResult MenuPartialResult()
        {
            int toplamKitapSayisi =
                myKitapManager.TumAktifKitaplariGetir().Count();
            TempData["ToplamKitapSayisi"]= toplamKitapSayisi;
            //umut viewbag dene
            return PartialView("_PartialMenu");
        }


    }
}