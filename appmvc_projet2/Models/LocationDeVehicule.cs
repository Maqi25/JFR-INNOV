using System;

namespace appmvc_projet2.Models
{
    public class LocationDeVehicule 
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }

        public Service Service { get; set; }
        public string ModeleVehicule { get; set; }
        public string TypeBoiteVitesse { get; set; }
        public string Motorisation { get; set; }

        public double Kilometrage { get; set; }

        public DateTime DateMiseEnService { get; set; }

        public int NombrePlace { get; set; }

    }
}
