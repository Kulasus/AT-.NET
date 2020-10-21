using ASPNETWEBAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ASPNETWEBAPP.Services
{
    public class ProductService
    {

        public List<Product> GetProducts() {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Koloběžka",
                    Price = 1000,
                    Description = "Modrá koloběžka"

                },
                new Product()
                {
                    Id = 2,
                    Name = "Motorka",
                    Price = 12000,
                    Description = "Rychlá motorka"

                },
                new Product()
                {
                    Id = 3,
                    Name = "Auto",
                    Price = 32000,
                    Description = "Sportovní auto"

                }
            };
        }
        public Product GetProduct(int id)
        {
            return this.GetProducts().FirstOrDefault(x => x.Id == id);
        }
    }
}
