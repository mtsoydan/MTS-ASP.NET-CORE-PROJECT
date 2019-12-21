using System;
using System.Collections.Generic;
using System.Text;
using MTS.Core.DataAcces;
using MTS.Nortwind.Entities.Concrete;

namespace MTS.Northwind.DataAcces.Abstract
{
    interface IProductDal : IEntityRepository<Product>
    {
        //Custom methods
    }
}
