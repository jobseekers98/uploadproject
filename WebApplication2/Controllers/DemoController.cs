using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DemoController : Controller
    {
        private readonly ApplicationContext dbcontext;

        public DemoController(ApplicationContext _dbContext) 
        {

            dbcontext = _dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
