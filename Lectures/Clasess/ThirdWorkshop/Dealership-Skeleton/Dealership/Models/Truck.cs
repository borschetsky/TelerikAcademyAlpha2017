using Dealership.Contracts;
using Dealership.Common.Enums;
using System;
using System.Text;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        //Frields
        private int weightCapacity;
        //Constructor
        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            if (weightCapacity > 100 || weightCapacity < 0)
            {
                throw new ArgumentException("Weight capacity must be between 1 and 100!");
            }
            this.Type = VehicleType.Truck;
            this.weightCapacity = weightCapacity;
            this.Wheels = (int)Type;
        }
        //Prop
        public int WeightCapacity { get {return this.weightCapacity; } set {this.weightCapacity = value; } }
        //Meth

        public override string AditionalInfo()
        {
            StringBuilder curTrack = new StringBuilder();
            curTrack.Append($"  Weight Capacity: {this.weightCapacity}t");
            return curTrack.ToString();
        }
    }
}
