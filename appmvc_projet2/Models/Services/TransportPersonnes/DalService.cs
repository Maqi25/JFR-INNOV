using System;
using System.Collections.Generic;

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

        public List<Service> ObtientTousLesServices()
        {
            throw new NotImplementedException();
        }

        public List<TransportDePersonnes> ObtientTousLesTransportsDePersonnes()
        {
            throw new NotImplementedException();
        }
    }
}
