﻿using SalesWebMvcUpdate.Models;
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
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
