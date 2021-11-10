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

        public Furniture(string name, string description, decimal cost,
        double width, double height, double weight, string warning)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Width = width;
            Height = height;
            Weight = weight;
            Warning = warning;
        }


    }

    class Elixir : Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

        public Elixir(string name, string description, decimal cost,
        string[] ingredients, string warning)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Ingredients = ingredients;
            Warning = warning;
        }

    }

    class Tobacco : Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

        public Tobacco(string name, string description, decimal cost,
        double width, double height, double weight, string[] ingredients, string warning)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Ingredients = ingredients;
            Warning = warning;
        }


     class MagicFood : Product                                                 // Test av GITHUB gör en random produkt för att se ifall det funkar. Vi kan säkert använda detta med ifall vi har tid att införa en extra 
     {  
            public string Name { get; set; }
            public string Descripion { get; set; }
            public decimal Cost { get; set; }
            public string Ingredients { get; set; }
            public string warning { get; set; }


            public MagicFood (string name, string description, decimal cost, 
                              int width, int height, string ingredients, string warning)
            { 
                Name = name;
                Descripion = description;
                Cost = cost;
                Ingredients = ingredients;
                Warning = warning; 

    }
    class Program
    {


        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Elixir(name, description, cost, ingredients, warning)); //Koden fungerar;
                                                                                     //men har ingen hänvisning då detaljerna ännu inte har några värden eller strängar.
          

        }
    }
}
