namespace appmvc_projet2.Models
{
    public class TransportDeColis 
    {   

        public int Id { get; set; }

        public int? ServiceId { get; set; }

        public Service Service { get; set; }
        public string NomDuColis { get; set; }
        public double Volume { get; set; }  
        public string Format { get; set; }  
        public string Nature { get; set; }
    }
}
