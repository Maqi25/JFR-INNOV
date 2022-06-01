using System.ComponentModel.DataAnnotations;

namespace appmvc_projet2.Models
{
    public class Personne
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Le Nom doit être rempli")]
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [Required(ErrorMessage = "L'email doit être rempli")]
        public string Email  { get; set; }
        public string Adresse { get; set; }
        [MaxLength(10)]
        [RegularExpression(@"^\d{10}", ErrorMessage = "Le numéro de téléphone doit contenir 10 chiffres.")]
        [Display(Name = "Téléphone")]
        public string NumeroTel { get; set; }
        

    }
}
