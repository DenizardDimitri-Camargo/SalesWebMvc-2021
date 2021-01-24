using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvcUpdate.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthdate { get; set; }
        
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")] //o 0 indica o valr do atributo, e F2 indica que ele vai ter duas casas decimais
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
