using MTS.Northwind.Business.Abstract;
using MTS.Northwind.DataAcces.Concrete.EntityFramework;
using MTS.Northwind.DataAcces.Abstract;
using MTS.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {

        private IProductDal _IProductDal;
        
        public ProductManager(IProductDal productService)
        {
            _IProductDal = productService;
        }
        public void Add(Product product)
        {
             _IProductDal.Add(product);
        }

        public void Delete(Product product)
        {
            _IProductDal.Add(product);
        }

        public List<Product> GetAll()
        {
          return  _IProductDal.GetList();
        }

        public List<Product> GetByCategory(Product product)
        {

            //Tüm ürünleri getirip sorgulamaz direk tek sorgu atar entity katmanı sorguyu render edip öyle veri tabanına gönderiyor
            return _IProductDal.GetList(p => p.CategoryID == product.ProductID);
        }

        public void Update(Product product)
        {
            _IProductDal.Update(product);
        }
    }
}
