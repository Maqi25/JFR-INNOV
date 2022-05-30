using System.Collections.Generic;
using System.Linq;

namespace appmvc_projet2.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;
        public Dal()
        {
            _bddContext = new BddContext();
        }
        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

        public List<PersonneInscrite> ObtientToutessLesPersonneInscrites()
        {
            return _bddContext.PersonneInscrites.ToList();
        }

        public void Dispose()
        {
            _bddContext.Dispose();
        }

        public int CreerPersonneInscrite(string nom, string prenom, string adresse, string email, string numeroTel, string statut)
        {
            PersonneInscrite personneInscrite = new PersonneInscrite() 
            { 
                Nom = nom,
                Prenom = prenom,
                Adresse = adresse,
                Email = email,
                NumeroTel = numeroTel,
                Statut = statut
            };
            _bddContext.PersonneInscrites.Add(personneInscrite);    
            _bddContext.SaveChanges();
            return personneInscrite.Id;
        }
    }
}
