using System;
using System.Collections.Generic;
using System.Text;
using Dealership.Common.Enums;
using Dealership.Contracts;


namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        //Fields
        private string model;
        private string make;
        private VehicleType type;
        private int wheels;
        private decimal price;
        private IList<IComment> comments;

        //Constructors
        public Vehicle(string make, string model, decimal price)
        { 
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.comments = new List<IComment>();
        }
        
        //Prop
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Model must be between 2 and 15 characters long!");
                }
                model = value;
            }
        }
        public string Make
        {
            get { return this.make; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Make must be between 2 and 15 characters long!");
                }
                make = value;
            }
        }
        public VehicleType Type { get { return this.type; } set { type = value; } }
        public int Wheels { get { return this.wheels; } protected set { wheels = value; } }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Price must be between 0.0 and 1000000.0!");
                }
                price = value;
            }
        }

        public IList<IComment> Comments { get { return this.comments; } set { comments = value; } }

        public abstract string AditionalInfo();

        public override string ToString()
        {
            StringBuilder currentVehicle = new StringBuilder();
            //currentVehicle.AppendLine($" {this.Type}");
            currentVehicle.AppendLine($"  Make: {this.make}");
            currentVehicle.AppendLine($"  Model: {this.model}");
            currentVehicle.AppendLine($"  Wheels: {this.wheels}");
            currentVehicle.AppendLine($"  Price: ${this.price}");
            currentVehicle.AppendLine(this.AditionalInfo());
            if (this.comments.Count == 0)
            {
                currentVehicle.Append("    --NO COMMENTS--");
            }
            else
            {
                currentVehicle.AppendLine("    --COMMENTS--");

                foreach (var coment in comments)
                {
                    currentVehicle.Append(coment);
                }
                
                currentVehicle.Append("    --COMMENTS--");


            }
            return currentVehicle.ToString();

        }

    }
}
