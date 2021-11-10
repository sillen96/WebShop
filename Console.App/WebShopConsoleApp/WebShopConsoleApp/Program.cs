using System;
using System.Collections.Generic;

namespace WebShopConsoleApp
{

    class Product //Superclass; Models
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

        public Product(string name, string description, decimal cost,
        double width, double height, double weight, string[] ingredients, string warning)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Width = width;
            Height = height;
            Weight = weight;
            Ingredients = ingredients;
            Warning = warning;
        }
    }



    class Furniture : Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Warning { get; set; }


    }

    class Elixir : Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

    }

    class Tobacco : Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            
        }
    }
}
