﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Databinding_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VerkoopbeheerEntities : DbContext
    {
        public VerkoopbeheerEntities()
            : base("name=VerkoopbeheerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Klant> Klanten { get; set; }
        public virtual DbSet<Orderlijn> Orderlijnen { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Producten { get; set; }
        public virtual DbSet<Werknemer> Werknemers { get; set; }
    }
}