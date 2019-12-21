using Microsoft.EntityFrameworkCore;
using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace MTS.Northwind.DataAccess.Concrete.EntityFrameWork
{
   public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PKLDNBN;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
