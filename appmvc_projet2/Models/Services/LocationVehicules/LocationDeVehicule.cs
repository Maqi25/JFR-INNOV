using System;
using System.ComponentModel.DataAnnotations;

namespace appmvc_projet2.Models.Services.LocationVehicules
{
    public class LocationDeVehicule
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }

        public Service Service { get; set; }
        [Display(Name = "Modèle du véhicule")]
        public string ModeleVehicule { get; set; }
        [Display(Name = "Type boite de vitesse")]
        public string TypeBoiteVitesse { get; set; }
        public string Motorisation { get; set; }
        [Display(Name = "Kilométrage")]

        public double Kilometrage { get; set; }
        [Display(Name = "Date de mise en service")]
        public DateTime DateMiseEnService { get; set; }
        [Display(Name = "Nombre de places")]
        public int NombrePlace { get; set; }

    }
}
