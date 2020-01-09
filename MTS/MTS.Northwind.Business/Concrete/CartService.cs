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
            //cart içinde değer varsa arttır yoksa ekle
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
            if (cartLine !=null)
            {
                cartLine.Quantity++;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity= 1 });
        }

        

        public void RemoveFromCart(Cart cart, int ProductID)
        {
            //kart içinde siparişi siliyoruz
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == ProductID);
           cart.CartLines.Remove(cartLine);
        }
        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;

        }
    }
}
