using System;
using System.ComponentModel.DataAnnotations;

namespace appmvc_projet2.Models.Services
{
    public class Service
    {
        public int Id { get; set; }
        [Display(Name = "Nom du service")]
        public string NomDuService { get; set; }
        public double Montant { get; set; }
        [Display(Name = "Lieu de départ")]
        public string LieuDeDepart { get; set; }
        [Display(Name = "Lieu d'arrivée")]
        public string LieuArrivee { get; set; }
        [Display(Name = "Date de début")]
        public DateTime DateDeDebut { get; set; }
        [Display(Name = "Date de fin")]
        public DateTime DateDeFin { get; set; }

    }
}
