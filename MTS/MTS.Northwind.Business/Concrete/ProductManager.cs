using MTS.Northwind.Business.Abstract;
using MTS.Northwind.DataAcces.Concrete.EntityFramework;

using MTS.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {

        
        public ProductManager()
        {

        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryID)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
