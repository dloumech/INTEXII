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
            var burials = _context.BurialmainTextiles
                .Include(bt => bt.Burialmain)
                .Include(bt => bt.Textile)
                .Join(_context.StructureTextiles,
                    bt => bt.Textile.Id,
                    st => st.MainTextileid,
                    (bt, st) => new { BurialmainTextile = bt, StructureTextile = st })
                .Join(_context.TextilefunctionTextiles,
                    bts => bts.BurialmainTextile.Textile.Id,
                    tft => tft.MainTextileid,
                    (bts, tft) => new { BurialmainTextile = bts.BurialmainTextile, StructureTextile = bts.StructureTextile, TextilefunctionTextile = tft })
                .Select(bts => new { bts.BurialmainTextile, bts.StructureTextile, bts.TextilefunctionTextile, bts.BurialmainTextile.Textile })
                .Join(_context.ColorTextiles,
                    bts => bts.Textile.Id,
                    ct => ct.MainTextileid,
                    (bts, ct) => new { BurialmainTextile = bts.BurialmainTextile, StructureTextile = bts.StructureTextile, TextilefunctionTextile = bts.TextilefunctionTextile, ColorTextile = ct })
                .Include(x => x.StructureTextile.Structure)
                .Take(10)
                .Select(x => x.BurialmainTextile)
                .ToList();

            return View(burials);
        }
    }
}
