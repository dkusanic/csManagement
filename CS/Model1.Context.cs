﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CS_ManagementEntities : DbContext
    {
        public CS_ManagementEntities()
            : base("name=CS_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dijelovi> Dijelovi { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Servis> Servis { get; set; }
        public virtual DbSet<Serviser> Serviser { get; set; }
        public virtual DbSet<Stavka_servisa> Stavka_servisa { get; set; }
        public virtual DbSet<Usluge> Usluge { get; set; }
        public virtual DbSet<Varijanta> Varijanta { get; set; }
        public virtual DbSet<Vlasnik> Vlasnik { get; set; }
        public virtual DbSet<Vlasnistvo> Vlasnistvo { get; set; }
        public virtual DbSet<Vozilo> Vozilo { get; set; }
    }
}