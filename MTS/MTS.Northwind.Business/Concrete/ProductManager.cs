using MTS.Northwind.Business.Abstract;
using MTS.Northwind.DataAccess.Abstract;
using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productdal)
        {
            _productDal = productdal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
            
        }

        public void Delete(Product productID)
        {
            _productDal.Delete(productID);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryID)
        {



            return _productDal.GetList(p => p.CategoryID == categoryID || categoryID == 0);
        }

        public Product GetByID(int ProductID)
        {
            return _productDal.Get(p => p.ProductID == ProductID);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);

        }
    }
}
