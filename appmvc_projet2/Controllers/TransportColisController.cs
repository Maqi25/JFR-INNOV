using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.TransportColis;
using appmvc_projet2.Models.Services.TransportPersonnes;
using appmvc_projet2.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace appmvc_projet2.Controllers
{
    public class TransportColisController : Controller
    {
        private IDal dal;
        private IWebHostEnvironment _webEnv;
        public TransportColisController(IWebHostEnvironment environment)
        {
            _webEnv = environment;
            this.dal = new Dal();
        }

        // Fonction permettant de lister tous les transport de colis sur la page index
        public ActionResult Index()
        {
            List<TransportDeColis> listeDesTransportsDeColis = dal.ObtientTousLesTransportsDeColis();
            return View(listeDesTransportsDeColis);
           
        }

        // fonction permettant de créer un transport de colis. Elle nous renvoit vers le formulaire de création d'un nouveau transport de colis
        public ActionResult Creer()
        {
            return View();
        }


        // fonction permettant de récupérer les informations renseigner dans le formulaire de création d'un nouveau transport et d'enregistrer les données dans la bdd
        [HttpPost]
        public ActionResult Creer(Service service, TransportDeColis transportDeColis)
        {
            using (Dal dal = new Dal())
            {
                dal.CreerTransportColis(service, transportDeColis);
                return RedirectToAction("Creer");
            }

        }

        // fonction permettant de modifier un transport de colis existant 
        public ActionResult Modifier(int? id, Service service)
        {
            if (id.HasValue)
            {
                TransportDeColis transportDeColis = dal.ObtientTousLesTransportsDeColis().FirstOrDefault(t => t.Id == id.Value);

                using (DalService dalService = new DalService())
                {
                    service = dalService.ObtientTousLesServices().FirstOrDefault(t => t.Id == transportDeColis.ServiceId);

                }
                // Utilisation du ViewModel afin d'afficher sur la page le model TransportDeColis et celui du Service
                ServiceViewModel transportDeColisVM = new ServiceViewModel()
                {
                    Service = service,
                    TransportDeColis = transportDeColis
                };



                if (transportDeColis == null)
                    return View("Error");
                
                return View(transportDeColisVM);
             
            }
            else
                return NotFound();
        }

 
        // fonction permettant de récupérer les données modifiées et de mettre à jour à la bdd 
        [HttpPost]
        public ActionResult Modifier(Service service, TransportDeColis transportDeColis)
        { //public ActionResult Modifier(TransportDeColis transportDeColis)
            if (!ModelState.IsValid)
                return View();



            if (transportDeColis.Image != null)
            {
                if (transportDeColis.Image.Length != 0)
                {
                    string uploads = Path.Combine(_webEnv.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, transportDeColis.Image.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        transportDeColis.Image.CopyTo(fileStream);
                    }
                    dal.Modifier(transportDeColis.Id, transportDeColis.ServiceId, transportDeColis.NomDuColis, transportDeColis.Volume,
                        transportDeColis.Format, transportDeColis.Nature, "/images/" + transportDeColis.Image.FileName);

                    

                    using (DalService dalService = new DalService())
                    {
                        
                        dalService.ModifierService(service.Id, service.NomDuService, service.LieuDeDepart, service.DateDeDebut,
                            service.LieuArrivee, service.DateDeFin, service.Montant);
                    }
                }
            }
            else
            {

                using (DalService dalService = new DalService())
                {
                    dalService.ModifierService(service.Id, service.NomDuService, service.LieuDeDepart, service.DateDeDebut,
                        service.LieuArrivee, service.DateDeFin, service.Montant);
                }
                dal.Modifier(transportDeColis.Id, transportDeColis.ServiceId, transportDeColis.NomDuColis, transportDeColis.Volume,
                        transportDeColis.Format, transportDeColis.Nature, transportDeColis.ImagePath);

              
            }
            return RedirectToAction("Index");
        }
    }
  
}
