using MTS.Northwind.Business.Abstract;
using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTS.Northwind.Business.Concrete
{
    public class CartService : ICartService
    {
       
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
            if (cartLine !=null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int ProductID)
        {
            CartLine cardLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == ProductID);
            cart.CartLines.Remove(cardLine);
        }
    }
}
