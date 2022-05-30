namespace appmvc_projet2.Models
{
    public class PersonneInscrite 
    {

        public int Id { get; set; }

        public int? PersonneId {get; set;}

        public Personne Personne { get; set; }
        public string Statut { get; set; }
    }
}
