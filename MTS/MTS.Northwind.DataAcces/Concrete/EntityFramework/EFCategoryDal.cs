using MTS.Core.Entities;
using MTS.Core.EntityFramework;
using MTS.Northwind.DataAcces.Abstract;
using MTS.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.DataAcces.Concrete.EntityFramework
{

    public class EFCategoryDal : EFEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        
    }
}
