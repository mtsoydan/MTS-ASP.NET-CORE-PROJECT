using System;
using System.Collections.Generic;
using System.Text;
using MTS.Northwi

using MTS.Core.DataAcces;

namespace MTS.Northwind.DataAcces.Abstract
{
    interface IProductDal : IEntityRepository<Product>
    {
    }
}
