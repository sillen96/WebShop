using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class ProductManager
    {
        private List<ProductModel> Products;


        public ProductModel()
        {
            Products = new List<ProductModel>()
            {
                new FurnitureModel()
                {
                    ID = "f01",
                    Name = "Lergoblin",
                    Image = "image here",
                    Description = "En liten figur som sjunger tvåstämmigt den kända ”Kloaksonaten” – inte särskilt vacker melodi, men underhållande!",
                    Cost = 50,
                    Height = 0.3d,
                    Width = 0.3d,
                    Weight = 0.2d,
                    Warning = "Varning: Avsaknad av avstängingsläge förekommer."
                },

                new FurnitureModel()
                {
                    ID = "f02",
                    Name = "Varma Muggen",
                    Image = "image here",
                    Description = "Är du inte trött på att behöva värma kaffet varje gång du glömt av att dricka den sista slurpen? "
                                  + "Oroa dig inte, denna magiska mugg är förtrollad med värmande magi och du behöver nu aldrig stressa dig i kaffet!",
                    Cost = 750,
                    Height = 0.5d,
                    Width = 0.5d,
                    Weight = 1,
                    Warning = "Vi ansvarar inte för eventuella för brända tungor under kaffe incidenter."
                },
            };
            return Products;
        }

        public List<ProductModel> FindAll()
        {
            return Products;
        }

        public ProductModel FindID(string id)
        {
            return Products.Where(p => p.ID == id).FirstOrDefault;
        }
    }
}
