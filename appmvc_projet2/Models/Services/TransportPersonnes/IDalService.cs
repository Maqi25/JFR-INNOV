using System;
using System.Collections.Generic;

namespace appmvc_projet2.Models.Services.TransportPersonnes
{
    public interface IDalService : IDisposable
    {
        void DeleteCreateDatabase();
        List<Service> ObtientTousLesServices();
        List<TransportDePersonnes> ObtientTousLesTransportsDePersonnes();

        int CreerService(string nomDuService, double montant, string lieuDeDepart, string lieuArrivee, DateTime dateDeDebut, DateTime dateDeFin);
        int CreerTransportDePersonnes(int serviceId, int nombreDePlace, string modele, string couleurModele);

    }
}
