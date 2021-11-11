using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class ProductModel
    {

        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    ID = 01,
                    Name = "Lergoblin",
                    Image = "image here",
                    Description = "En liten figur som sjunger tvåstämmigt den kända ”Kloaksonaten” – inte särskilt vacker melodi, men underhållande!",
                    Cost = 50,
                    Height = 0.3d,
                    Width = 0.3d,
                    Weight = 0.2d,
                    Warning = "Varning: Avsaknad av avstängingsläge förekommer."
                }


            }
        }
    }
}
