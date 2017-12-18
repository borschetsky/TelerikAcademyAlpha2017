using Dealership.Contracts;
using System;
using Dealership.Models;
using Dealership.Common.Enums;

namespace Dealership.Factories
{
    public class DealershipFactory : IDealershipFactory
    {
        public Car CreateCar(string make, string model, decimal price, int seats)
        {
            Car newCar = new Car(make, model, price, seats);
            return newCar;
        }

        public Motorcycle CreateMotorcycle(string make, string model, decimal price, string category)
        {
            Motorcycle newMoto = new Motorcycle(make, model, price, category);
            return newMoto;
        }

        public Truck CreateTruck(string make, string model, decimal price, int weightCapacity)
        {
            Truck newTruck = new Truck(make, model, price, weightCapacity);
            return newTruck;
        }

        public IUser CreateUser(string username, string firstName, string lastName, string password, string role)
        {
            User newUser = new User(username, firstName, lastName, password, role);
            return newUser;
        }

        public IComment CreateComment(string content)
        {
            Comment newComm = new Comment(content);
            return newComm;
        }
    }
}
