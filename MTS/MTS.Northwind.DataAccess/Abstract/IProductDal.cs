using MTS.Core.DataAccess;
using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.DataAccess.Abstract
{
  public  interface IProductDal : IEntityRepository<Product>
    {
        
        //Custom operations 
    }
}
