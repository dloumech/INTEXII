using INTEXII.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXII.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private fagelgamous_databaseContext _context { get; set; }
        public HomeController(ILogger<HomeController> logger, fagelgamous_databaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult BurialRecord()
        {
            var burials = _context.Burialmains
                .ToList();

            return View(burials);
        }

        [HttpGet]
        public IActionResult AddRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecord(Burialmain bm)
        {
            if (ModelState.IsValid)
            {
                // Generate a random key between 20000000000000000 and 99999999999999999
                Random random = new Random();
                long key = (long)(random.NextDouble() * (99999999999999999 - 20000000000000000) + 20000000000000000);

                // Check if the key already exists in the database
                while (_context.Burialmains.Any(b => b.Id == key))
                {
                    key = (long)(random.NextDouble() * (99999999999999999 - 20000000000000000) + 20000000000000000);
                }

                // Set the generated key for the new record
                bm.Id = key;

                // Add and save the new record
                _context.Add(bm);
                _context.SaveChanges();

                return View("Confirmation");
            }

            else //invalid data
            {
                return View(bm);
            }
        }

        [HttpGet]
        public IActionResult Summary(int burialId)
        {
            var burial = _context.Burialmains.Single(x => x.Id == burialId);

            return View(burial);
        }
    }
}
