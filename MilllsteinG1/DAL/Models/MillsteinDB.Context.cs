﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MillsteinDBEntities : DbContext
    {
        public MillsteinDBEntities()
            : base("name=MillsteinDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advisory> Advisory { get; set; }
        public virtual DbSet<CEO> CEO { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Investment> Investment { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Firm> Firm { get; set; }
    }
}
