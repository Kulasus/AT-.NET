using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPNETWEBAPP.Models;
using ASPNETWEBAPP.Services;
using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNETWEBAPP.Controllers
{
    public class HomeController : BaseController
    {
        private ProductService productService;

        public HomeController(ProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            ViewBag.Products = productService.GetProducts();
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Product = productService.GetProduct(id);
            return View();
        }
        public IActionResult AddToBasket(int id)
        {
            List<int> list;
            if (this.HttpContext.Session.TryGetValue("basket", out byte[] data)){
                string txt = Encoding.UTF8.GetString(data);
                list = txt.Split(',').Select(x => int.Parse(x)).ToList();
            }
            else
            {
                list = new List<int>();
            }
            list.Add(id);
            data = Encoding.UTF8.GetBytes(string.Join(",", list));
            this.HttpContext.Session.Set("basket", data);

            return RedirectToAction("Detail", "Home", new { id = id });
        }

        public IActionResult Basket()
        {
            List<SelectListItem> options = new List<SelectListItem>()
            {
                new SelectListItem("osobni odběr", "1"),
                new SelectListItem("PPL", "2"),
                new SelectListItem("-","3")
            };
            ViewBag.TransportationOptions = options;
            return View();
        }

        [HttpPost]
        public IActionResult Basket(OrderForm form)
        {
            List<int> list = null;
            if (this.HttpContext.Session.TryGetValue("basket", out byte[] data))
            {
                string txt = Encoding.UTF8.GetString(data);
                list = txt.Split(',').Select(x => int.Parse(x)).ToList();
            }

            if(list == null || list.Count == 0)
            {
                ModelState.AddModelError(string.Empty, "Košík je prázdný!");
            }

            if (ModelState.IsValid)
            {
                /// save to db
                return RedirectToAction("Done", "Homes");
            }
            return this.Basket();
        }

        public IActionResult Done()
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
