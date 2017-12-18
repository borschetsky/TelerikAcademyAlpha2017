using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Text;

namespace Cosmetics.Products
{
    public class Cream : Product, ICream, IProduct  
    {
        //Fields
        private ScentType scent;
        //Const
        public Cream(string name, string brand, decimal price, GenderType gender ,ScentType scent) 
            : base(name, brand, price, gender)
        {
            Guard.WhenArgument(name.Length, "cream name").IsLessThan(3).IsGreaterThan(15).Throw();
            Guard.WhenArgument(brand.Length, "cream brand").IsLessThan(3).IsGreaterThan(15).Throw();
                
            
            this.Scent = scent;
        }

        //Prop
        public ScentType Scent { get => scent; set => scent = value; }

        public override string Print()
        {
            StringBuilder currentCream = new StringBuilder();
            currentCream.Append(base.Print());
            currentCream.AppendLine($" #Scent: {this.scent}");
            currentCream.Append($" ===");
            return currentCream.ToString(); 
        }
    }
}
