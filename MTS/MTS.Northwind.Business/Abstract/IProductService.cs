using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Abstract
{
    public interface IProductService
    {
        //Ekstra bir miras alma yoluna gitmemize gerek yok işimize yaramayacaktır sadece nesneyle alakalı metodlarburada olmalı
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryID);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product productID);
        Product GetByID(int ProductID);


    }
}
