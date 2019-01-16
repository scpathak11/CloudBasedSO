using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOGenerator.Data;
using SOGenerator.Models;

namespace SOGenerator.Controllers
{
    public class HomeController : Controller
    {
        private SOGeneratorDBContext _db;

        public HomeController(SOGeneratorDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var salesOrders = _db.SalesOrders.ToList();
            return View(salesOrders);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SalesOrder model)
        {
            _db.SalesOrders.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
