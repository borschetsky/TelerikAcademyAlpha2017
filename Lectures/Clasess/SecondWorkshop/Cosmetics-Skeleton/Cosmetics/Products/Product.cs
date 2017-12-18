using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;


namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        //Const
        public Product(string name, string brand, decimal price, GenderType gender)
        {
            if (name == null || brand == null)
            {
                throw new ArgumentNullException();
            }
            Guard.WhenArgument(name.Length, "name").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand.Length, "Brand").IsLessThan(2).IsGreaterThan(10).Throw();
            Guard.WhenArgument(price, "price").IsLessThan(0).Throw();
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        //Prop
        public string Name { get { return this.name; }set { this.name = value; }}
        public string Brand { get => brand; set => brand = value; }
        public decimal Price { get => price; set => price = value; }
        public GenderType Gender { get => gender; set => gender = value; }

        public virtual string Print()
        {
            StringBuilder abstrRes = new StringBuilder();
            abstrRes.AppendLine($"#{this.name} {this.brand}");
            abstrRes.AppendLine($" #Price: ${this.price}");
            abstrRes.AppendLine($" #Gender: {this.gender}");
            return abstrRes.ToString();
        }
    }
}