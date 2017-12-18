using Dealership.Contracts;
using Dealership.Common.Enums;
using System;
using System.Text;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        //Fields
        private string category;
        //Const
        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
           
            if (Wheels > 2)
            {
                throw new ArgumentException();
            }
            this.Category = category;
            this.Type = VehicleType.Motorcycle;
            this.Wheels = (int)Type;
        }
        //Prop
        public string Category
        {
            get {return this.category; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 3 || value.Length > 10 )
                {
                    throw new ArgumentException("Category must be between 3 and 10 characters long!");
                }
                this.category = value;
            }
        }

        public override string AditionalInfo()
        {
            StringBuilder currMoto = new StringBuilder();
            currMoto.Append($"  Category: {this.Category}");
            return currMoto.ToString();
        }
    }
}
