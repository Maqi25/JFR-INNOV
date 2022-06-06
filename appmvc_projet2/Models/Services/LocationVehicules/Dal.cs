using appmvc_projet2.Models.Services.TransportPersonnes;
using System;

namespace appmvc_projet2.Models.Services.LocationVehicules
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

        public int CreerLocationDeVehicule(int serviceId, string modeleVehicule, string typeBoite, string motorisation, double kilometrage, DateTime dateMiseEnService, int nbrePlace)
        {
            throw new NotImplementedException();
        }
        public int CreerLocationDeVehicule(LocationDeVehicule locationDeVehicule)
        {
            _bddContext.LocationDeVehicules.Update(locationDeVehicule);
            _bddContext.SaveChanges();
            return locationDeVehicule.Id;
        }
        public void CreerLocationVehicule(Service service, LocationDeVehicule locationDeVehicule)
        {
            using (DalService dalService = new DalService())
            {
                locationDeVehicule.ServiceId = dalService.CreerService(service);
                _ = CreerLocationDeVehicule(locationDeVehicule);
            }

        }


    }
}
