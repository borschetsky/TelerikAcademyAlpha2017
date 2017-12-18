using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
            : base (name, brand,price, gender)
        {
            Guard.WhenArgument(ingredients, "in").IsNull().Throw();
            this.Ingredients = ingredients;
        }

        public string Ingredients { get => ingredients; set => ingredients = value; }

        public override string Print()
        {
            StringBuilder currentPaste = new StringBuilder();
            currentPaste.Append(base.Print());
            currentPaste.AppendLine($" Ingridients: {this.ingredients}");
            currentPaste.Append($" ===");
            return currentPaste.ToString();
        }
    }
}