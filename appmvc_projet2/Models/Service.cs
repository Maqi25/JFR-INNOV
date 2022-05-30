using System;

namespace appmvc_projet2.Models
{
    public class Service
    {
        public int Id { get; set; } 
        public string NomDuService { get; set; }
        public double Montant { get; set; } 
        public string LieuDeDepart { get; set; }
        public string LieuArrivee { get; set; }
        public DateTime DateDeDebut { get; set; }
        public DateTime DateDeFin { get; set; }  

    }
}
