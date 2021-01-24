using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvcUpdate.Services;

namespace SalesWebMvcUpdate.Controllers
{
    public class SellersController : Controller
    {
        public SellerService _sellerService { get; set; }

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
