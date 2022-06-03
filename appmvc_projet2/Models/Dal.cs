using System;
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
        public void Dispose()
        {
            _bddContext.Dispose();
        }
        public List<PersonneInscrite> ObtientToutessLesPersonneInscrites()
        {
            return _bddContext.PersonneInscrites.ToList();
        }

     

        public int CreerPersonneInscrite(int personneId, string statut)
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
        public int CreerPersonne(string nom, string prenom, string adresse, string email, 
            string numeroTel, string mdp, string statut, 
            Role role, DateTime datenaissance)
        {
            Personne personne = new Personne()
            {
                Nom = nom,
                Prenom = prenom,
                Adresse = adresse,
                Email = email,
                NumeroTel = numeroTel,
                Password = mdp,
                Statut = statut,
              //  DateNaissance = datenaissance,
                Role = Role.Admin
            };
            _bddContext.Personnes.Add(personne);
            _bddContext.SaveChanges();
            return personne.Id;
        }

        public void CreerPersonne(Personne personne)
        {
            _bddContext.Personnes.Update(personne);
            _bddContext.SaveChanges();
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

        public void ModifierPersonne(Personne personne)
        {
            _bddContext.Personnes.Update(personne);
            _bddContext.SaveChanges();
        }

        public List<Personne> ObtientToutesLesPersonnes()
        {
            return _bddContext.Personnes.ToList();
        }

        public void ModifierPersonneInscrite(int id, string nom, string prenom, string adresse, string email, string numeroTel)
        {
            throw new System.NotImplementedException();
        }

       /* public void CreerCompte()
        {
            using (Dal dal = new Dal())
            {

                int id = dal.CreerPersonne("joe", "jack", "5bis ananas paris", "joejack@gmail.com", "0907030506");
                dal.CreerPersonneInscrite(id, "provider");
            }
        }*/
    }
}
