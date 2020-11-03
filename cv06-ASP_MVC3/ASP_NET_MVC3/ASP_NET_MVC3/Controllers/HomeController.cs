using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP_NET_MVC3.Models;
using Microsoft.AspNetCore.Http;

namespace ASP_NET_MVC3.Controllers
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

        [HttpPost]
        public IActionResult Index(LoginForm form)
        {
            //Základní validace formuláře
            if (ModelState.IsValid)
            {
                //Validace emailu
                if (form.Email != "abc@def.com")
                {
                    //Změna stavu ModelState na Invalid
                    ModelState.AddModelError("Email", "Uživatel nebyl nalezen.");
                }
                //Validace hesla
                if (ModelState.IsValid && form.Password != "12345")
                {
                    //Změna stavu ModelState na Invalid
                    ModelState.AddModelError("Password", "Nesprávné heslo.");
                }
                //Znova základní validace celého formuláře
                if (ModelState.IsValid)
                {
                    //Uložení emailu do Session
                    this.HttpContext.Session.SetString("Email", form.Email);

                    //Přesměrování
                    return RedirectToAction("Index","ToDoList");
                }
            }
            //Obnovení stránky s loginem + zobrazení chybových hlášek
            return View(form);
        }

        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove("Email");
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
