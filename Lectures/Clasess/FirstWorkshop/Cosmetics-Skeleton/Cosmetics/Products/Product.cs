using Bytes2you.Validation;
using Cosmetics.Common;
using System;

namespace Cosmetics.Products
{
    public class Product
    {
        private readonly decimal price;
        private readonly string name;
        private readonly string brand;
        private readonly GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            Guard.WhenArgument(price, "price").IsLessThan(0).Throw();
            Guard.WhenArgument(brand.Length, "branf").IsLessThan(2).Throw();
            Guard.WhenArgument(brand.Length, "brand").IsGreaterThan(10).Throw();
            Guard.WhenArgument(name.Length, "name").IsLessThan(3).IsGreaterThan(10).Throw();
            this.name = name;
            this.brand = brand;

            this.price = price;
            this.gender = gender;
        }

        public string Name => name;

        public string Brand => brand;

        public decimal Price => price;

        public GenderType Gender => gender;

        public string Print()
        {
            return $" #{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n ===";
        }
    }
}
