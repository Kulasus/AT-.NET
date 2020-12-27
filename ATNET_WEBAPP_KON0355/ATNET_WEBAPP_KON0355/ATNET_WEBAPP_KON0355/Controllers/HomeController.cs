using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ATNET_WEBAPP_KON0355.Models;
using ATNET_WEBAPP_KON0355.Exceptions;

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
                ModelState.AddModelError("Credentials", GlobalizationResources.Resources.CredentialsError);
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

        [HttpPost]
        public IActionResult Data(ShowForm form)
        {
            if(form.Name == null || form.Name.Length <= 0)
            {
                ModelState.AddModelError("NameError", GlobalizationResources.Resources.NameError);
            }
            if(form.Episodes <= 0 || form.Series <= 0)
            {
                ModelState.AddModelError("EpisodesSeriesError", GlobalizationResources.Resources.EpisodesSeriesError);
            }
            if(form.Character == null || form.Character.Length <=0)
            {
                ModelState.AddModelError("CharacterError", GlobalizationResources.Resources.CharacterError);
            }
            if (ModelState.IsValid)
            {
                Show dummy = new Show(form.Name, form.Episodes, form.Series, form.Character);
            }
            return this.Data();
        }

        public IActionResult DeleteShow(int id)
        {
            try
            {
                Show.deleteShow(id);
                return RedirectToAction("Data", "Home");
            }
            catch (ShowNotFoundException e) {
                Debug.WriteLine(e.ToString());
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult EditShow(int id)
        {
            if (Show.containsById(id))
            {
                ViewBag.editedShow = Show.getOneById(id);
                return View();
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public IActionResult EditShow(ShowForm form)
        {
            //Rewriting values from old record to eliminate bugs with bad value setting in fields in Razor
            Show oldShow = Show.getOneById(form.ID);
            form.Name = form.Name == null ? oldShow.Name : form.Name;
            form.Character = form.Character == null ? oldShow.Character : form.Character;
            form.Episodes = form.Episodes <= 0 ? oldShow.Episodes : form.Episodes;
            form.Series = form.Series <= 0 ? oldShow.Series : form.Series;
            Show.updateShow(form);
            return RedirectToAction("Data", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
