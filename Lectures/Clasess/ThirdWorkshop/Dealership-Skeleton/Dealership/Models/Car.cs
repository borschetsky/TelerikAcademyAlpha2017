using Dealership.Contracts;
using Dealership.Common.Enums;
using Bytes2you.Validation;
using System;
using System.Text;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        //Fields
        private int seats;
        //Const
        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            
            
            
            if (seats < 0 || seats > 10)
            {
                throw new ArgumentException("Seats must be between 1 and 10!");
            }
            this.Seats = seats;
            this.Type = VehicleType.Car;
            this.Wheels = (int)Type;
        }
        
        //Prop
        public int Seats
        {
            get {return seats; }
            set { this.seats = value; }
        }

        public override string AditionalInfo()
        {
            StringBuilder currentCar = new StringBuilder();
            currentCar.Append($"  Seats: {this.seats}");
            return currentCar.ToString();
        }
    }

    

   

    
}
