using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleVendas.Models;
using ControleVendas.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControleVendas.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;

        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _sellerService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
