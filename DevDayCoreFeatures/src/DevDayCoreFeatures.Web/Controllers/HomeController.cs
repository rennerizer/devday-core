using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DevDayCoreFeatures.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            if (HttpContext.Items["Instructions"] != null)
                ViewBag.Instructions = HttpContext.Items["Instructions"].ToString();

            return View();
        }
    }
}
