using appmvc_projet2.Models.Services.TransportPersonnes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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

    
        public int CreerTransportDeColis(int serviceId, string nomDuColis, double volume, string format, string nature)
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
            return _bddContext.TransportDeColis.Include(t => t.Service).ToList();
        }

        public void Modifier(int id, int serviceId, string nomDuColis, double volume, string format, string nature, string imagePath)
        {
            TransportDeColis transport = this._bddContext.TransportDeColis.Find(id);
            if (transport != null)
            {
                transport.ServiceId = serviceId;
                transport.NomDuColis = nomDuColis;
                transport.Volume = volume;
                transport.Format = format;
                transport.Nature = nature;
                transport.ImagePath = imagePath;
                this._bddContext.SaveChanges();
            }
        }

       
    }
}
