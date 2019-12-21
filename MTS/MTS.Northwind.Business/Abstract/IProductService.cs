using MTS.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategory(Product product);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);


    }

}
