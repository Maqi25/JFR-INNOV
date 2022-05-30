namespace appmvc_projet2.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public virtual PersonneInscrite PersonneInscrite { get; set; }  

        public virtual Service Service { get; set; }
    }
}
