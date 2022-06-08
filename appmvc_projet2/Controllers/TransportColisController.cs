using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.TransportColis;
using Microsoft.AspNetCore.Mvc;

namespace appmvc_projet2.Controllers
{
    public class TransportColisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Creer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Creer(Service service, TransportDeColis transportDeColis)
        {
            using (Dal dal = new Dal())
            {
                dal.CreerTransportColis(service, transportDeColis);
                return RedirectToAction("Creer");
            }

        }
    }
  
}
