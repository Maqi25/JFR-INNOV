namespace appmvc_projet2.Models
{
    public class AideALaPersonne 
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        public string TypeAide { get; set; }
    }
}
