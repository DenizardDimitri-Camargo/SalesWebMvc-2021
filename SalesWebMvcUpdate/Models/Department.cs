using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvcUpdate.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        
        public Department()
        {
        }

        public Department(string name)//o seed precisa usar ctor sem Id, o EF ou BD vai colocar automaticamente
        {
            Name = name;
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final)); //PULO DO GATO: usou o método da outra entidade.
        }
    }
}
