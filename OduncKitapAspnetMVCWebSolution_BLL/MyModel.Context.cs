﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OduncKitapAspnetMVCWebSolution_BLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OduncKitapDBEntities : DbContext
    {
        public OduncKitapDBEntities()
            : base("name=OduncKitapDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kitaplar> Kitaplar { get; set; }
        public virtual DbSet<OduncIslemler> OduncIslemler { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Turler> Turler { get; set; }
        public virtual DbSet<Uyeler> Uyeler { get; set; }
        public virtual DbSet<Yazarlar> Yazarlar { get; set; }
    }
}
