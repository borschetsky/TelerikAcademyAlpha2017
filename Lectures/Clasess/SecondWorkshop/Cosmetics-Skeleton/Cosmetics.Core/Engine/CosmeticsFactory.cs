using Cosmetics.Cart;
using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products;
using System;
using System.Collections.Generic;

namespace Cosmetics.Core.Engine
{
    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            return new Category(name);
        }

        public Shampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            var currentShampoo = new Shampoo(name, brand, price, gender, milliliters, usage);
            return currentShampoo;
        }

        public Toothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            var currentPaste = new Toothpaste(name, brand, price, gender, string.Join(", ", ingredients));
            return currentPaste;
        }

        public Cream CreateCream(string name, string brand, decimal price, GenderType gender, ScentType scent)
        {
            var currentCream = new Cream(name, brand, price, gender, scent);
            return currentCream;
        }

        public ShoppingCart CreateShoppingCart()
        {
            var currentSpopCart = new ShoppingCart();
            return currentSpopCart;
        }
    }
}
