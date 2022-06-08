using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appmvc_projet2.Models.Services.TransportColis
{
    public class TransportDeColis
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        [Display(Name = "Nom du colis")]
        public string NomDuColis { get; set; }
        [Display(Name = "Volume du colis")]
        public double Volume { get; set; }
        [Display(Name = "Format du colis")]
        public string Format { get; set; }
        [Display(Name = "Nature du colis")]
        public string Nature { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }

    }

    public enum Nature
    {
        Solide, 
        Fragile,
        Liquide
    }
}
