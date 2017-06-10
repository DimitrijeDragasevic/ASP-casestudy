using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPcasestudy.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;

namespace ASPcasestudy.DAL
{
    public class ProductsContext : DbContext
    {


      

        public DbSet<DesktopComputers> DesktopComputers { get; set; }
        public DbSet<Laptops> Laptops{ get; set; }
        public DbSet<Tablets> Tablets { get; set; }
        public DbSet<Keyboards> Keyboards{ get; set; }
        public DbSet<Mouse> Mouse{ get; set; }
        public DbSet<ComputerComponents> ComputerComponents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<DesktopComputers>().ToTable("DesktopComputers");
            modelBuilder.Entity<Laptops>().ToTable("Laptops");
            modelBuilder.Entity<Tablets>().ToTable("Tablets");
            modelBuilder.Entity<Keyboards>().ToTable("Keyboards");
            modelBuilder.Entity<Mouse>().ToTable("Mouse");
            modelBuilder.Entity<ComputerComponents>().ToTable("ComputerComponents");

        }
        public ProductsContext() : base()
        {
            Database.Log = sql => Debug.Write(sql);
           

        }
            
    }


}