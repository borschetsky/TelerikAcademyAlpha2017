using Dealership.Contracts;
using Dealership.Common.Enums;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Dealership.Models
{
    public class User : IUser
    {
        //Fields
        private string username;
        private string firstName;
        private string lastName;
        private string passWord;
        private Role role;
        private IList<IVehicle> vehicles;
        //Constructor
        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.Vehicles = new List<IVehicle>();
        }
        //Ptop
        public string Username
        {
            get { return this.username; }
            set
            {
                if (value == null || value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Username must be between 2 and 20 characters long!");
                }
                string usernamePattern = "^[A-Za-z0-9]+$";
                if (!Regex.IsMatch(value, usernamePattern))
                {
                    throw new ArgumentException("Username contains invalid symbols!");
                }
                this.username = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set 
            {
                if (value == null || value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Firstname must be between 2 and 20 characters long!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null || value.Length < 2 || value.Length > 20 )
                {
                    throw new ArgumentException("Lastname must be between 2 and 20 characters long!");
                }
                this.lastName = value;
            }
        }
        public string Password
        {
            get { return this.passWord; }
            set
            {
                if (value == null || value.Length < 5 || value.Length > 30)
                {
                    throw new ArgumentException("Password must be between 5 and 30 characters long!");
                }
                string passwordPattern = "^[A-Za-z0-9@*_-]+$";
                if (!Regex.IsMatch(value, passwordPattern))
                {
                    throw new ArgumentException("Password contains invalid symbols!");
                }
                this.passWord = value;
            }
        }
        public Role Role { get { return this.role; } set { this.role = value; } }
        public IList<IVehicle> Vehicles { get { return this.vehicles; } set { this.vehicles = value; } }
        //Methods
        public void AddVehicle(IVehicle vehicle)
        {
            if (role == Role.Admin)
            {
                throw new ArgumentException("You are an admin and therefore cannot add vehicles!");
            }
            if (vehicles.Count >= 5 && role != Role.VIP)
            {
                throw new ArgumentException("You are not VIP and cannot add more than 5 vehicles!");
            }

            vehicles.Add(vehicle);
            

            
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new Exception();
            }
            vehicles.Remove(vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (this.Username != commentToRemove.Author)
            {
                throw new Exception("You are not the author!");

            }
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public string PrintVehicles()
        {
            if (this.vehicles.Count() == 0)
            {
                return $"--USER {this.username}--\n--NO VEHICLES--";
            }
            StringBuilder str = new StringBuilder();
            str.Append($"--USER {this.username}--\n");
            for (int i = 0; i < this.vehicles.Count; i++)
            {
                str.Append($"{i + 1}. {this.vehicles[i].GetType().Name}:\n");
                str.AppendLine($"{this.vehicles[i].ToString()}");
                
            }
            return str.ToString().Trim();
        }

        public override string ToString()
        {

            return $"Username: {this.username}, FullName: {this.firstName} {this.lastName}, Role: {this.role}";
        }
    } }
