using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecordStore.DAL.Entity.Record;
using RecordStore.Domain.RecordService.Interfaces;
using RecordStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RecordStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRecordService _recordService;

        public HomeController(ILogger<HomeController> logger, IRecordService recordService)
        {
            _logger = logger;
            _recordService = recordService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> InsertData(RecordData recordData)
        {
            return Json(await _recordService.InsertData(recordData));
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
