﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoogleApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<miasta> miastas { get; set; }
        public virtual DbSet<obiekty> obiekties { get; set; }
        public virtual DbSet<panstwa> panstwas { get; set; }
        public virtual DbSet<trasa_naglowek> trasa_naglowek { get; set; }
        public virtual DbSet<trasa_obiekt> trasa_obiekt { get; set; }
        public virtual DbSet<uprawnienia> uprawnienias { get; set; }
        public virtual DbSet<uzytkownicy> uzytkownicies { get; set; }
    }
}
