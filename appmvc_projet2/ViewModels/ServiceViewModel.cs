using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.AidePersonnes;
using appmvc_projet2.Models.Services.LocationVehicules;
using appmvc_projet2.Models.Services.TransportColis;
using appmvc_projet2.Models.Services.TransportPersonnes;


namespace appmvc_projet2.ViewModels
{
    public class ServiceViewModel
    {

        public Service Service{ get; set;}  
        public TransportDePersonnes TransportDePersonnes { get; set; }
        public TransportDeColis TransportDeColis { get; set; }
        public LocationDeVehicule LocationDeVehicule { get; set; }
        public AideALaPersonne aideALaPersonne { get; set; }

    
    }
}
