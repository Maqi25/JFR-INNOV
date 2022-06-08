using appmvc_projet2.Models.Services.TransportPersonnes;

namespace appmvc_projet2.Models.Services.AidePersonnes
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
        public int CreerAideALaPersonne(AideALaPersonne aideALaPersonne)
        {
            _bddContext.AideAuxPersonnes.Update(aideALaPersonne);
            _bddContext.SaveChanges();
            return aideALaPersonne.Id;
        }
        public void CreerAidePersonne(Service service, AideALaPersonne aideALaPersonne)
        {
            using (DalService dalService = new DalService())
            {
                aideALaPersonne.ServiceId = dalService.CreerService(service);
                _ = CreerAideALaPersonne(aideALaPersonne);
            }

        }


    }
}
