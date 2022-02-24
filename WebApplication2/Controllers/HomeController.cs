using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationContext dbcontext;
        public HomeController(ILogger<HomeController> logger, ApplicationContext _dbcontext)
        {
            _logger = logger;
            dbcontext = _dbcontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Index(tbl_location location)
        {
          
            
                var data = dbcontext.tbl_Locations.Add(location);
                await dbcontext.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
                ViewBag.msg = "Record has been Added";
            
                return View(location);
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
