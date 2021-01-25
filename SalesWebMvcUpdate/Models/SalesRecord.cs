using SalesWebMvcUpdate.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvcUpdate.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; } //FK
        
        public SalesRecord()
        {
        }

        public SalesRecord(DateTime date, double amount, SaleStatus status, Seller seller)//o seed precisa usar ctor sem Id, o EF ou BD vai colocar automaticamente
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
