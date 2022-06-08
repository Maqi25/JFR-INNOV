using appmvc_projet2.Models;
using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.TransportPersonnes;
using appmvc_projet2.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace appmvc_projet2.Controllers
{
    public class TransportPersonnesController : Controller
    {
        private IDalService dal;
        private IWebHostEnvironment _webEnv;
        public TransportPersonnesController(IWebHostEnvironment environment)
        {
            _webEnv = environment;
            this.dal = new DalService();
        }
        public IActionResult Index()
        {
            List<TransportDePersonnes> listeDesTransportsDePersonnes = dal.ObtientTousLesTransportsDePersonnes();
            return View(listeDesTransportsDePersonnes);
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


        // fonction permettant de modifier un transport de personne existant 
        public ActionResult Modifier(int? id, Service service)
        {
            if (id.HasValue)
            {
                TransportDePersonnes transportDePersonnes  = dal.ObtientTousLesTransportsDePersonnes().FirstOrDefault(t => t.Id == id.Value);

              service = dal.ObtientTousLesServices().FirstOrDefault(t => t.Id == transportDePersonnes.ServiceId);

                // Utilisation du ViewModel afin d'afficher sur la page html le model TransportDePersonnes et celui du Service
                ServiceViewModel transportDePersonnesVM = new ServiceViewModel()
                {
                    Service = service,
                    TransportDePersonnes = transportDePersonnes
                };



                if (transportDePersonnes == null)
                    return View("Error");

                return View(transportDePersonnesVM);
                
            }
            else
                return NotFound();
        }


        // fonction permettant de récupérer les données modifiées et de mettre à jour à la bdd 
        [HttpPost]
        public ActionResult Modifier(Service service, TransportDePersonnes transportDePersonnes)
        { 
            if (!ModelState.IsValid)
                return View();

            if (transportDePersonnes.Image != null)
            {
                if (transportDePersonnes.Image.Length != 0)
                {
                    string uploads = Path.Combine(_webEnv.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, transportDePersonnes.Image.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        transportDePersonnes.Image.CopyTo(fileStream);
                    }
                    dal.Modifier(transportDePersonnes.Id, transportDePersonnes.ServiceId, transportDePersonnes.NombreDePlace, transportDePersonnes.Modele,
                        transportDePersonnes.CouleurModele, "/images/" + transportDePersonnes.Image.FileName);


                     dal.ModifierService(service.Id, service.NomDuService, service.LieuDeDepart, service.DateDeDebut,
                            service.LieuArrivee, service.DateDeFin, service.Montant);
          
                }
            }
            else
            {

               
                    dal.ModifierService(service.Id, service.NomDuService, service.LieuDeDepart, service.DateDeDebut,
                        service.LieuArrivee, service.DateDeFin, service.Montant);
              
                    dal.Modifier(transportDePersonnes.Id, transportDePersonnes.ServiceId, transportDePersonnes.NombreDePlace, transportDePersonnes.Modele,
                        transportDePersonnes.CouleurModele, transportDePersonnes.ImagePath);


            }
            return RedirectToAction("Index");
        }
    }





}

