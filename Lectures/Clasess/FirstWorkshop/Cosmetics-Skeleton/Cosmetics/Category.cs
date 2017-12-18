using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics
{
    public class Category
    {
        private readonly string name;
        private readonly List<Product> products;

        public Category(string name)
        {
            Guard.WhenArgument(name.Length, "name").IsLessThan(2).IsGreaterThan(15).Throw();
            
            this.name = name;
            this.products = new List<Product>();
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
        }

        public string Name => name;

        public List<Product> Products1 => products;

        public virtual void AddProduct(Product product) 
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            
            products.Add(product);
            products.OrderBy(x => x.Brand).ThenByDescending(x => x.Price);
            
            

        }

        public virtual void RemoveProduct(Product product)
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            if(!products.Any(pr => pr.Name == product.Name))
            {
                throw new ArgumentNullException();
            }
            products.Remove(product);
            
        }

        public string Print()
        {
            var strBuilder = new StringBuilder();
            var result = new StringBuilder();

            if (Products1.Count() == 0)
            {
                result.Append($"#Category: {name}\r\n #No product in this category");
            }
            else
            {
                result.Append($"#Category: {name}\r\n");
            }

            foreach (var product in this.Products1)
            {
                strBuilder.AppendLine(product.Print());
            }

          
            return result.ToString();
        }
    }
}
