using INTEXII.Models;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult BurialRecord( int pageNum = 1)
        {


            int pageSize = 50; // number of records per page

            // calculate the number of records to skip based on the current page number and page size
            int skip = (pageNum - 1) * pageSize;

            // retrieve a subset of the data from the database using Skip() and Take() methods
            var burials = _context.Burialmains
                .Skip(skip)
                .Take(pageSize)
                .ToList();

            // calculate the total number of pages based on the total number of records and page size
            int totalPages = (int)Math.Ceiling(_context.Burialmains.Count() / (double)pageSize);

            // pass the subset of data and pagination information to the view
            ViewBag.CurrentPage = pageNum;
            ViewBag.TotalPages = totalPages;

            return View(burials);


        }

        //attempt to clear cache
        public IActionResult ClearFilters()
        {
            return RedirectToAction("BurialRecord");
        }

        public IActionResult RecordFilter()
        {
            return View();
        }

        public IActionResult UAnalysis()
        {
            return View("UnsupervisedAnalysis");
        }

        public IActionResult SAnalysis()
        {
            return View("SupervisedAnalysis");
        }

        [HttpGet]
        //[Authorize]
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

        public IActionResult FilterRecords(string sex, string burialdepth, string estimatestature, string ageatdeath, string headdirection, string squarenorthsouth, string northsouth, string squareeastwest, string eastwest, string area, string burialnumber, string haircolor)
        {
            var burials = _context.Burialmains;

            // Your code to filter records based on the form values goes here
            var filteredRecords = burials.Where(b =>
           (string.IsNullOrEmpty(sex) || b.Sex == sex) &&
           (string.IsNullOrEmpty(burialdepth) || b.Depth == burialdepth) &&
           (string.IsNullOrEmpty(estimatestature) || b.Length == estimatestature) &&
           (string.IsNullOrEmpty(ageatdeath) || b.Ageatdeath == ageatdeath) &&
           (string.IsNullOrEmpty(headdirection) || b.Headdirection == headdirection) &&
           (string.IsNullOrEmpty(squarenorthsouth) || b.Squarenorthsouth == squarenorthsouth) &&
           (string.IsNullOrEmpty(northsouth) || b.Northsouth == northsouth) &&
           (string.IsNullOrEmpty(squareeastwest) || b.Squareeastwest == squareeastwest) &&
           (string.IsNullOrEmpty(eastwest) || b.Eastwest == eastwest) &&
           (string.IsNullOrEmpty(area) || b.Area == area) &&
           (string.IsNullOrEmpty(burialnumber) || b.Burialnumber == burialnumber) &&
           (string.IsNullOrEmpty(haircolor) || b.Haircolor == haircolor)).ToList();

            // Return the filtered records to the BurialRecord view
            return View("BurialRecord", filteredRecords);
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var burial = _context.Burialmains.Single(x => x.Id == id);

            return View("AddRecord", burial);
        }

        [HttpPost]
        public IActionResult Edit(Burialmain bm)
        {
            if (ModelState.IsValid)
            {
                _context.Update(bm);
                _context.SaveChanges();

                return RedirectToAction("BurialRecord");
            }

            else //invalid data
            {
                return View("AddRecord", bm);
            }
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            var burial = _context.Burialmains.Single(x => x.Id == id);

            return View(burial);
        }

        [HttpPost]
        public IActionResult Delete(Burialmain bm)
        {
            _context.Burialmains.Remove(bm);
            _context.SaveChanges();

            return RedirectToAction("BurialRecord");
        }

    }
}
