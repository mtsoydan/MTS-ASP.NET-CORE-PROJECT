using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Business.Abstract
{
   public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int ProductID);
        List<CartLine> List(Cart cart);
    }
}
