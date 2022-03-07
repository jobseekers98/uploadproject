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
        //public async Task< IActionResult> Index(EmployeeViewModel model)
        //{

            
        //    var data = dbcontext.tbl_Locations.Add(location);
        //    await dbcontext.SaveChangesAsync();
        //    // return RedirectToAction(nameof(Index));
        //    ViewBag.msg = "Record has been Added";

        //    return RedirectToAction(Index);
        //}


        public IActionResult Privacy()
        {
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult BindData() 
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> BindData(tbl_location tbl)
        {
            //tbl_location tbl = new tbl_location();
            //tbl.Id = Id;
            //tbl.Latitude = latitude;
            //tbl.Address = Address;
            //tbl.Longitude = longitude;

            dbcontext.tbl_Locations.Add(tbl);
            await dbcontext.SaveChangesAsync();
            // return RedirectToAction(nameof(Index));
            ViewBag.msg = "Record has been Added";

            return View(tbl);
        }

        [HttpGet]
        public IActionResult ConcateNateQuery()
        {
            return View();
        }

        [HttpPost]
        //public async Task<IActionResult> ConcateNateQuery(location_Concatenate tbl)
        //{

        //    dbcontext.tbl_LocConcate.Add(tbl);
        //    await dbcontext.SaveChangesAsync();
        //    // return RedirectToAction(nameof(Index));
        //    //ViewBag.msg = "Record has been Added";

        //    return View(tbl);

       
        //}

        [HttpGet]
        public IActionResult Test()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> Test(location_Concatenate tbl)
        {
         
            dbcontext.tbl_LocConcate.Add(tbl);
            await dbcontext.SaveChangesAsync();
            // return RedirectToAction(nameof(Index));
            //ViewBag.msg = "Record has been Added";

            return View(tbl);

        }

        [HttpGet]
        public IActionResult TestDropDown()
        {
            //var productsList = (from product in dbcontext.tbl_BindDropDown
            //                    select new StateList()
            //                    {
            //                        Text = product.State,
            //                        //Value = product.Id(),
            //                    }).ToList();

            //productsList.Insert(0, new StateList()
            //{
            //    Text = "----Select----",
            //  //  Value = string.Empty
            //});

            //return View(productsList);
            EmployeeVM model = new EmployeeVM();
           // model.StateDropDownList = dbcontext.tbl_BindDropDown.Select(x => new StateList { Value = x.Id, Text = x.State }).ToList();
            return View(model);

        }



        [HttpPost]
        public  IActionResult TestDropDown(EmployeeVM model)
        {
            try
            {
                var a = model.Address.Split(',');
                model.Address = $"{a[0]}, {a[1]}, {a[2]}";
                EmployeeViewModel vm = new EmployeeViewModel()
                {
                    City = model.City,
                    State = model.State,
                    District = model.District,
                    country = model.country,
                    Latitude = model.Latitude,
                    Longitude = model.Longitude,
                    Postal = model.Postal,
                    Address = model.Address,
                };
                dbcontext.tbl_BindDropDown.Add(vm);
                int i= dbcontext.SaveChanges();
                //  dbcontext.tbl_LocConcate.Add(tbl);
                //await dbcontext.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
                //ViewBag.msg = "Record has been Added";
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
           
            return View(model);
        }



    }
}
