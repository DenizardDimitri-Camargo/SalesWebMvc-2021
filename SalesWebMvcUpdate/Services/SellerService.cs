using Microsoft.EntityFrameworkCore;
using SalesWebMvcUpdate.Models;
using SalesWebMvcUpdate.Services.Exceptions;
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
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id); //Include faz o join da tabela Deparment
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            //var seller = _context.Seller.Find(id);
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Seller.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e) //se acontecer esta exception do EF...
            {
                throw new DbConcurrencyException(e.Message); //... vou relançar uma Exception a nivel de serviço, para segregar
            }
        }
    }
}
