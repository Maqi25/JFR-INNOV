namespace appmvc_projet2.Models
{
    public class TransportDePersonne 
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        public int NombreDePlace { get; set; }
    }
}
