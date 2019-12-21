using MTS.Northwind.Business.Abstract;
using MTS.Northwind.DataAcces.Abstract;
using MTS.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Concrete
{
    public class CategoryService : ICategoryService

    {

        private ICategoryDal _categoryService;
        public CategoryService(ICategoryDal categoryService )
        {
            _categoryService = categoryService;
        }
        public List<Category> GetAll()
        {
            return _categoryService.GetList ();
        }
    }
}
