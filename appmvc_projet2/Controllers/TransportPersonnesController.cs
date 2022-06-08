using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.TransportPersonnes;
using appmvc_projet2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace appmvc_projet2.Controllers
{
    public class TransportPersonnesController : Controller
    {
        public IActionResult Index()
        {
            Service service = new Service()
            {
                NomDuService = "Transport de personnes",
                Montant = 10,
                LieuDeDepart = "PARIS",
                LieuArrivee = "Lille",
                DateDeDebut = new DateTime(2022, 06, 05),
                DateDeFin = new DateTime(2022, 06, 05)
            };

            TransportDePersonnes transportDePersonnes = new TransportDePersonnes()
            {
                NombreDePlace = 3,
            };
            ServiceViewModel tpvm = new ServiceViewModel()
            {
              
                Service = service,
                TransportDePersonnes = transportDePersonnes
            };
            return View(tpvm);
        }

        public IActionResult Creer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Creer(Service service, TransportDePersonnes transportDePersonnes)
        {
            using (DalService dalService = new DalService())
            {
                dalService.CreerTransportPersonnes(service, transportDePersonnes);
                return RedirectToAction("Creer");
            }
            
        }




      
    }
}
