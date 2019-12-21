using Microsoft.EntityFrameworkCore;
using MTS.Core.Entities;
using MTS.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.DataAcces.Concrete.EntityFramework
{
   public class NorthwindContext :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PKLDNBN;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Category>Products { get; set; }
        public DbSet<Product> Categorys { get; set; }

    }
}
