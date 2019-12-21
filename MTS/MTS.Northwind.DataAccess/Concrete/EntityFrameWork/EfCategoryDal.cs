using MTS.Core.DataAccess.EntityFrameWork;
using MTS.Northwind.DataAccess.Abstract;
using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.DataAccess.Concrete.EntityFrameWork
{
   public class EfCategoryDal : EFRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
       

    }
}
