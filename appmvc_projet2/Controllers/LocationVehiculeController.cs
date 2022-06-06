using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.LocationVehicules;
using Microsoft.AspNetCore.Mvc;

namespace appmvc_projet2.Controllers
{
    public class LocationVehiculeController : Controller
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
        public IActionResult Creer(Service service, LocationDeVehicule locationDeVehicule)
        {
            using (Dal dal = new Dal())
            {
                dal.CreerLocationVehicule(service, locationDeVehicule);
                return RedirectToAction("Creer");
            }

        }
    }
}
