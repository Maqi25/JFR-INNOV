using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.AidePersonnes;
using Microsoft.AspNetCore.Mvc;

namespace appmvc_projet2.Controllers
{
    public class AidePersonneController : Controller
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
        public IActionResult Creer(Service service, AideALaPersonne aideALaPersonne)
        {
            using (Dal dal = new Dal())
            {
                dal.CreerAidePersonne(service, aideALaPersonne);
                return RedirectToAction("Creer");
            }

        }
    }
}
