using System;
using System.Collections.Generic;

namespace WebShopConsoleApp
{

    class Product //Superclass; Models
    {
        public int ID { get; set; }
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
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Warning { get; set; }

        public Furniture(int id, string name, string description, decimal cost,
        double width, double height, double weight, string warning)
        {
            ID = id;
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
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

        public Elixir(int id, string name, string description, decimal cost,
        string[] ingredients, string warning)
        {
            ID = id;
            Name = name;
            Description = description;
            Cost = cost;
            Ingredients = ingredients;
            Warning = warning;
        }

    }
    class Tobacco : Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

        public Tobacco(int id, string name, string description, decimal cost,
        string[] ingredients, string warning)
        {
            ID = id;
            Name = name;
            Description = description;
            Cost = cost;
            Ingredients = ingredients;
            Warning = warning;
        }


     class MagicFood : Product                                                 // Test av GITHUB g�r en random produkt f�r att se ifall det funkar. Vi kan s�kert anv�nda detta med ifall vi har tid att inf�ra en extra 
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

            products.Add(new Furniture(
            0,
            "Lergoblin",
            "En liten figur som sjunger tv�st�mmigt den k�nda �Kloaksonaten� � inte s�rskilt vacker melodi, men underh�llande!",
            50,
            0.3d,
            0.3d,
            0.2d,
            "Varning: En tyst l�ge inkluderas inte i produkten."
            ));

            string[] array = { "En krossad t�nagel fr�n ett troll", "tre nypor troll�rt", "svett fr�n en j�tte" };
            products.Add(new Elixir(
                1,
                "Blyfot",
                "Denna magiska brygd vid konsumption kommer g�ra ena foten tjugo kilo tyngre.",
                100,
                array,
                "Biverkningar kan f�rekomma: Sv�righeter att springa, f�rs�mrad balansf�rm�ga, en.. tung fot."
            ));


            foreach (var item in products) // f�r varje > f�rem�l > i listan "products>
                                            // IFALL > f�rem�let �r "Furniture" >
                                            // K�r koden nedan (allts� alla meddelanden)
            {
                if (item is Furniture)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(((Furniture)item));
                    Console.WriteLine(((Furniture)item).ID);
                    Console.WriteLine(((Furniture)item).Name);
                    Console.WriteLine(((Furniture)item).Description);
                    Console.WriteLine(((Furniture)item).Width);
                    Console.WriteLine(((Furniture)item).Height);
                    Console.WriteLine(((Furniture)item).Weight);
                    Console.WriteLine(((Furniture)item).Cost);
                    Console.WriteLine(((Furniture)item).Warning);
                    Console.WriteLine();
                }

                if (item is Elixir)
                {
                    Console.WriteLine();
                    Console.WriteLine(((Elixir)item));
                    Console.WriteLine(((Elixir)item).ID);
                    Console.WriteLine("Namn: " + ((Elixir)item).Name);
                    Console.WriteLine(((Elixir)item).Description);
                    Console.WriteLine(((Elixir)item).Cost);
                    Console.WriteLine(((Elixir)item).Ingredients); //F�rs�ker komma p� en l�sning f�r hantera arrays
                    Console.WriteLine(((Elixir)item).Warning);
                    Console.WriteLine();
                }
            }

        }
    }
}

/*      ID = id;
        Name = name;
        Description = description;
        Cost = cost;
        Ingredients = ingredients;
        Warning = warning;*/
