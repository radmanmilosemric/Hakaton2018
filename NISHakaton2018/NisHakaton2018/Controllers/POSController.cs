using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NisHakaton2018.Models;
using NisHakaton2018.Repository;

namespace NisHakaton2018.Controllers
{
    public class POSController : Controller
    {
        private readonly DBContex _context;
        public POSController(DBContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var artikli = _context.Roba.ToList();

            var model = new POSViewModel
            {
                ArtikliNaStanju = artikli.Select(o => new SelectListItem { Text = o.NazivRobe, Value = o.SifraRobe }).ToList()
            };
            return View(artikli);
        }
    }
}