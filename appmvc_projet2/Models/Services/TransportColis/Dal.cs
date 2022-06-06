using appmvc_projet2.Models.Services.TransportPersonnes;
using System;
using System.Collections.Generic;

namespace appmvc_projet2.Models.Services.TransportColis
{
    public class Dal : IDal
    {
        private BddContext _bddContext;
        public Dal()
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

    
        public int CreerTransportDeColis(int serviceId, string nomDuColis, string volume, string format, string nature)
        {
            throw new System.NotImplementedException();
        }

        public int CreerTransportDeColis(TransportDeColis transportDeColis)
        {
            _bddContext.TransportDeColis.Update(transportDeColis);
            _bddContext.SaveChanges();
            return transportDeColis.Id;
        }


        public void CreerTransportColis(Service service, TransportDeColis transportDeColis)
        {
            using (DalService dalService = new DalService())
            {
                transportDeColis.ServiceId = dalService.CreerService(service);
                _ = CreerTransportDeColis(transportDeColis);
            }

        }

        public List<TransportDeColis> ObtientTousLesTransportsDeColis()
        {
            throw new System.NotImplementedException();
        }

       
    }
}
