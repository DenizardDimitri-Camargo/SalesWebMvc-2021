using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvcUpdate.Models;
using SalesWebMvcUpdate.Models.ViewModels;
using SalesWebMvcUpdate.Services;

namespace SalesWebMvcUpdate.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments }; 
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //evita ataques na hora de autenticar
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index)); //poderia ter colocado "Index", mas com indexof fica melhor a manutenção
        }
    }
}
