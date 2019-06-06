using FinalMerch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FinalMerch.DAL
{
    public class MerchContext : DbContext
    {
        public MerchContext() : base("MerchContext")
        { }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Position> Bays { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}