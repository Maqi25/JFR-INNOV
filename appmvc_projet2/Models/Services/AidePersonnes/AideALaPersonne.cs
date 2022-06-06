using System.ComponentModel.DataAnnotations;

namespace appmvc_projet2.Models.Services.AidePersonnes
{
    public class AideALaPersonne
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        [Display(Name = "Type d'aide")]
        public string TypeAide { get; set; }
    }
}
