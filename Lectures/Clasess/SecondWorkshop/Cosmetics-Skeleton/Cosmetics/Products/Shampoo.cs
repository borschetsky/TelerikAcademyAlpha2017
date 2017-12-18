using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Text;



namespace Cosmetics.Products
{
    public class Shampoo : Product,IShampoo
    {
        private uint mililiters;
        private UsageType usage;
        //Const
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint mililiters, UsageType usage) 
            : base(name, brand, price, gender)
        {
            this.Mililiters = mililiters;
            this.Usage = usage;
        }
        public uint Mililiters { get => mililiters; set => mililiters = value; }
        public UsageType Usage { get => usage; set => usage = value; }

        public override string Print()
        {
            StringBuilder curShampoo = new StringBuilder();
            curShampoo.Append(base.Print());
            curShampoo.AppendLine($" #Mililiters: {this.mililiters}");
            curShampoo.AppendLine($" #Usage: {this.usage}");
            curShampoo.Append($" ===");
            return curShampoo.ToString();
        }

       
    }
}
