using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DRReceiver.Models;
using DRReceiver.Data;

namespace DRReceiver.Controllers
{
    public class HomeController : Controller
    {
        private DRReceiverDBContext _db;

        public HomeController(DRReceiverDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var salesOrders = _db.SalesOrders.ToList();
            return View(salesOrders);
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
