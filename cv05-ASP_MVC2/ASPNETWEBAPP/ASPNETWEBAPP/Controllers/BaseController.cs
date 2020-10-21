using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETWEBAPP.Controllers
{
    public abstract class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            List<int> list;
            if (this.HttpContext.Session.TryGetValue("basket", out byte[] data))
            {
                string txt = Encoding.UTF8.GetString(data);
                list = txt.Split(',').Select(x => int.Parse(x)).ToList();
            }
            else
            {
                list = new List<int>();
            }
            ViewBag.Basket = list;
            base.OnActionExecuting(context);
        }
    }
}
