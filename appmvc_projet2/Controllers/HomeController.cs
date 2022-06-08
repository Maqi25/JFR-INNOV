using appmvc_projet2.Models;
using Microsoft.AspNetCore.Mvc;

namespace appmvc_projet2.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
