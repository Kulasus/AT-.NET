using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestATNET_KON0355.Models;
using TestATNET_KON0355.Services;

namespace TestATNET_KON0355.Controllers
{
    public class HomeController : Controller
    {
        private JsonService jsonService;
        public HomeController(JsonService jsonService)
        {
            this.jsonService = jsonService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FormModel form)
        {
            if (ModelState.IsValid)
            {
                jsonService.SaveToJson(form);
                return RedirectToAction("Data", "Home");
            }
            return View();
        }

        public IActionResult Data()
        {
            List<FormModel> data = jsonService.LoadFromJson();
            ViewBag.Data = data;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
