using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP_NET_MVC3.Models;
using ASP_NET_MVC3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ASP_NET_MVC3.Controllers
{
    public class ToDoListController : AuthBaseController
    {
        private readonly ToDoFormService formService;
        public ToDoListController(ToDoFormService formService)
        {
            this.formService = formService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Items = await formService.GetItems();
            return View();
        }
    
        [HttpPost]
        public async Task<IActionResult> Index(ToDoForm form)
        {
            if (ModelState.IsValid)
            {
                await formService.Add(form.Text);

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteItemForm form)
        {
            await formService.DeleteItem(form.Text);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Download()
        {
            var items = await this.formService.GetItems();
            MemoryStream ms = new MemoryStream();
            using StreamWriter sw = new StreamWriter(ms, Encoding.UTF8, 1024, true);
            foreach(var item in items)
            {
                await sw.WriteLineAsync(item);
            }
            sw.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(ms, "text/csv")
            {
                FileDownloadName = "todo.csv"
            };

        }

    }
}
