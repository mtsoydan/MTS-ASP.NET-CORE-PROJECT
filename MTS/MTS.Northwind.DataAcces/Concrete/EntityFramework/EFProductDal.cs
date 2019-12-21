using System;
using System.Collections.Generic;
using System.Text;
using MTS.Core.Entities;
using MTS.Core.EntityFramework;
using MTS.Northwind.DataAcces.Abstract;
using MTS.Nortwind.Entities.Concrete;

namespace MTS.Northwind.DataAcces.Concrete.EntityFramework
{
   public class EFProductDal : EFEntityRepositoryBase<Product, NorthwindContext>,IProductDal
    {

    }
    
}
