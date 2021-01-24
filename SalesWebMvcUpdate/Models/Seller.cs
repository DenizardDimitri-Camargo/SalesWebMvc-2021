using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvcUpdate.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //criou a FK no BD quando fiz migration, mas como null
        public int DepartmentId { get; set; } //avisa ao EF que este ID vai ter que existir(int not null)
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(string name, string email, DateTime birthdate, double baseSalary, Department department)//o seed precisa usar ctor sem Id, o EF ou BD vai colocar automaticamente
        {
            Name = name;
            Email = email;
            Birthdate = birthdate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Seller(int id, string name, string email, DateTime birthdate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Birthdate = birthdate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            Sales.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //double totalSales = 0; //SEM LINQ
            //foreach (var item in Sales)
            //{
            //    if (item.Date >= initial && item.Date <= final)
            //        totalSales += item.Amount;
            //}

            //return totalSales;

            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final) //obtenho lista neste intervalo de data
                .Sum(sr => sr.Amount);
        }
    }
}
