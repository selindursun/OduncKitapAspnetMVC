﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OduncKitapAspnetMVCWebSolution_BLL.Managers
{
    public class OduncIslemManager
    {
        //global alan
        OduncKitapDBEntities dbContext = new OduncKitapDBEntities();
        public bool OduncIslemEkle(OduncIslemler yeniOduncIslem)
        {
            try
            {
                bool sonuc = false;
                dbContext.OduncIslemler.Add(yeniOduncIslem);
                dbContext.SaveChanges();
                sonuc = true;
                return sonuc;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
