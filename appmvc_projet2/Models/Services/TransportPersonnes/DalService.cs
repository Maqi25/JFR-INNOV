using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace appmvc_projet2.Models.Services.TransportPersonnes
{
    public class DalService : IDalService
    {
        private BddContext _bddContext;
        public DalService()
        {
            _bddContext = new BddContext();
        }
        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }
        public void Dispose()
        {
            _bddContext.Dispose();
        }
        public int CreerService(string nomDuService, double montant, string lieuDeDepart, string lieuArrivee, DateTime dateDeDebut, DateTime dateDeFin)
        {
            Service service = new Service()
            {
                NomDuService = nomDuService,
                Montant = montant,
                LieuDeDepart = lieuDeDepart,
                LieuArrivee = lieuArrivee,
                DateDeDebut = dateDeDebut,
                DateDeFin = dateDeFin
            };
            return service.Id;
        }

        public int CreerService(Service service)
        {
            _bddContext.Services.Update(service);
            _bddContext.SaveChanges();
            return service.Id;
        }

       

        public int CreerTransportDePersonnes(int serviceId, int nombreDePlace, string modele, string couleurModele)
        {

            TransportDePersonnes transportDePersonnes = new TransportDePersonnes()
            {
                ServiceId = serviceId,
                NombreDePlace = nombreDePlace,
                Modele = modele,
                CouleurModele = couleurModele
            };
            //_bddContext.TransportDePersonnes.Add(transportDePersonnes);
            _bddContext.TransportDePersonnes.Update(transportDePersonnes);
            _bddContext.SaveChanges();
            return transportDePersonnes.Id;
        }
       

        public int CreerTransportDePersonnes(TransportDePersonnes transportDePersonnes)
        {
            _bddContext.TransportDePersonnes.Update(transportDePersonnes);
            _bddContext.SaveChanges();
            return transportDePersonnes.Id;
        }

        public void CreerTransportPersonnes(Service service, TransportDePersonnes transportDePersonnes)
        {
            transportDePersonnes.ServiceId = CreerService(service);
            _ = CreerTransportDePersonnes(transportDePersonnes);
        }

        public void ModifierService(int id, string nomDuService, string lieuDeDepart, DateTime dateDeDebut, string lieuArrivee,  DateTime dateDeFin, double montant)
        {
            Service service = _bddContext.Services.Find(id);
            if (service != null)
            {
                service.NomDuService = nomDuService;
                service.LieuDeDepart = lieuDeDepart;
                service.DateDeDebut = dateDeDebut;
                service.LieuArrivee = lieuArrivee;
                service.DateDeFin = dateDeFin;
                service.Montant = montant;
                _bddContext.SaveChanges();
            }
        }
     
        public void Modifier(int id, int serviceId, int nombreDePlace, string modele, string couleurModele, string imagePath)
        {
            TransportDePersonnes transportDePersonnes = _bddContext.TransportDePersonnes.Find(id);
            if (transportDePersonnes != null)
            {
                transportDePersonnes.ServiceId = serviceId;
                transportDePersonnes.NombreDePlace = nombreDePlace;
                transportDePersonnes.Modele = modele;
                transportDePersonnes.CouleurModele = couleurModele;
                transportDePersonnes.ImagePath = imagePath;
                _bddContext.SaveChanges();
            }
        }

     

        public List<Service> ObtientTousLesServices()
        {
            return _bddContext.Services.ToList();
        }

        public List<TransportDePersonnes> ObtientTousLesTransportsDePersonnes()
        {
            return _bddContext.TransportDePersonnes.Include(t => t.Service).ToList();
        }

    
    }
}
