using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATNET_WEBAPP_KON0355.Models;

namespace ATNET_WEBAPP_KON0355.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm form)
        {
            if(form.Username != "admin" && form.Password != "admin")
            {
                ModelState.AddModelError("Credentials", "Invalid credentials");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Data", "Home");
            }
            return this.Login();
        }

        public IActionResult Data()
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
