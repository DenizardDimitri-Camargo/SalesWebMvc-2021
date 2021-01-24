using SalesWebMvcUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcUpdate.Services
{
    public class SellerService
    {
        public readonly SalesWebMvcUpdateContext _context;

        public SellerService(SalesWebMvcUpdateContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            var seller = _context.Seller.FirstOrDefault(x => x.Id == id);
            if (seller != null)
                return seller;

            return null;
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }
    }
}
