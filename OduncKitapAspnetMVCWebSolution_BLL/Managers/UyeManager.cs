﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OduncKitapAspnetMVCWebSolution_BLL.Managers
{
    public class UyeManager
    {
        //Global alan
        OduncKitapDBEntities dbContext = new OduncKitapDBEntities();
        public List<Uyeler> TumAktifUyeleriGetir()
        {
            try
            {
                List<Uyeler> uyeList = new List<Uyeler>();
                uyeList = dbContext.Uyeler
                    .Where(x => !x.SilindiMi).ToList();
                return uyeList;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
