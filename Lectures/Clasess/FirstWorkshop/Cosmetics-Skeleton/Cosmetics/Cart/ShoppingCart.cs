using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Cart
{
    public class ShoppingCart
    {
        private readonly ICollection<Product> productList;

        public ShoppingCart()
        {
            this.productList = new List<Product>();
        }

        public ICollection<Product> ProductList
        {
            get { return this.productList; }
        }

        public void AddProduct(Product product)
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            

            ProductList.Add(product);
            
        }

        public void RemoveProduct(Product product)
        {
            Guard.WhenArgument(product, "pr").IsNull().Throw();
            if(!productList.Any(pr => pr.Name == product.Name))
            {
                throw new NullReferenceException();
            }
            ProductList.Remove(product);
            //throw new NotImplementedException();
        }

        public bool ContainsProduct(Product product)
        {
            Guard.WhenArgument(product, "pr").IsNull().Throw();
            return ProductList.Contains(product);
            //throw new NotImplementedException();
        }

        public decimal TotalPrice()
        {

            return productList.Sum(pr => pr.Price);
        }
    }
}
