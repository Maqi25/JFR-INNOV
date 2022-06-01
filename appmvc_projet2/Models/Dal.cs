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

        public int CreerPersonneInscrite(int personneId,string statut)
        {
            PersonneInscrite personneInscrite = new PersonneInscrite() 
            { 
              PersonneId = personneId,
                Statut = statut
            };
            _bddContext.PersonneInscrites.Add(personneInscrite);    
            _bddContext.SaveChanges();
            return personneInscrite.Id;
        }
        public int CreerPersonne(string nom, string prenom, string adresse, string email, string numeroTel)
        {
            Personne personne = new Personne()
            {
                Nom = nom,
                Prenom = prenom,
                Adresse = adresse,
                Email = email,
                NumeroTel = numeroTel


            };
            _bddContext.Personnes.Add(personne);
            _bddContext.SaveChanges();
            return personne.Id;
        }

        public void ModifierPersonne(int id, string nom, string prenom, string adresse, string email, string numeroTel)
        {
            Personne personne = _bddContext.Personnes.Find(id);

            if (personne != null)
            {
                personne.Nom = nom;
                personne.Prenom = prenom;
                personne.Adresse = adresse;
                personne.Email = email;
                personne.NumeroTel = numeroTel;
                _bddContext.SaveChanges();
            }

        }

        public List<Personne> ObtientToutesLesPersonnes()
        {
            return _bddContext.Personnes.ToList();
        }

        
    }
}
