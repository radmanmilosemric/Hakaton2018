using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;
using NisHakaton2018.Repository;

namespace NisHakaton2018.Controllers
{
    public class DataStatisticController : Controller
    {
        private readonly DBContex _context;
        public DataStatisticController(DBContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult TransactionCountByStationType()
        {
            var stationTypes = _context.VrstaBS.ToList();

            var _chart = new Chart
            {
                labels = stationTypes.Select(o => o.Naziv).ToArray(),
                datasets = new List<Datasets>()
            };

            List<Datasets> _dataSet = new List<Datasets>();

            var transactions = _context.Transakcije.ToList();

            var transByStat = new List<string>();

            foreach (var item in stationTypes)
            {
                transByStat.Add(transactions.Count(o => o.SifraBS == item.SifraBS).ToString());
            }

            _dataSet.Add(new Datasets
            {
                label = "Transactions by Stations type",
                type = "bar",
                data = transByStat.ToArray(),
                yAxisID = "y-axis-1"
            });

            _chart.datasets = _dataSet;
            return Json(_chart);
        }
    }
}