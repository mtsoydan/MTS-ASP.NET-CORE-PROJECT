using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Abstract
{
  public  interface ICategoryService
    {
        List<Category> GetAll();
    }
}
