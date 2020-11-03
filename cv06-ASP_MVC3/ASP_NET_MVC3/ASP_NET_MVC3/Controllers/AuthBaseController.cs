using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ASP_NET_MVC3.Controllers
{
    public abstract class AuthBaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Session.TryGetValue("Email", out byte[] data))
            {
                context.Result = new RedirectToActionResult("Index", "Home", new { });
            }
        }
    }
}
