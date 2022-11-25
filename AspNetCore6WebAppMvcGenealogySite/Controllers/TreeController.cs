using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore6WebAppMvcGenealogySite.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCore6WebAppMvcGenealogySite.Controllers
{
    public class TreeController : Controller
    {
        // GET: /<controller>/

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        // POST : Tree
        [HttpPost]
        public IActionResult CreateFamilyTree(IFormCollection fc)
        {
            try
            {
                string firstName = fc["FirstName"];
                string lastName = fc["LastName"];

                ViewData["FirstName"] = firstName;
                ViewData["LastName"] = firstName;
                return RedirectToAction("CreateFamilyTree");
            }
            catch
            {
            //     ViewData["FirstName"] = null;
            //     ViewData["LastName"] = null;
            //     ViewData["Error"] = "Something went wrong";
                 return RedirectToAction("Index");
            }
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

