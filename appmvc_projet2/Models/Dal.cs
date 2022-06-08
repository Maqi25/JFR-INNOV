using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
           
            _bddContext.Database.EnsureCreated();
        }

<<<<<<< Updated upstream
        public List<PersonneInscrite> ObtientToutessLesPersonneInscrites()
        {
            return _bddContext.PersonneInscrites.ToList();
        }

=======
>>>>>>> Stashed changes
        public void Dispose()
        {
            _bddContext.Dispose();
        }
<<<<<<< Updated upstream

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
=======
 
        public List<Personne> ObtientToutesLesPersonnes()
        {
            return _bddContext.Personnes.ToList();
        }
      
      
        public Personne Authentifier(string email, string password)
        {
            string motDePasse = EncodeMD5(password);
            Personne user = this._bddContext.Personnes.FirstOrDefault(u => u.Email == email && u.Password == motDePasse);
            return user;
        }
        public Personne ObtenirUtilisateur(int id)
        {
            return this._bddContext.Personnes.FirstOrDefault(u => u.Id == id);
        }

        public Personne ObtenirUtilisateur(string idStr)
>>>>>>> Stashed changes
        {
            int id;
            if (int.TryParse(idStr, out id))
            {
                return this.ObtenirUtilisateur(id);
            }
            return null;
        }
        public static string EncodeMD5(string password)
        {
            string motDePasseSel = "JfkInnov" + password + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        public Personne AjouterUtilisateur(string nom, string prenom, string adresse, string email, string numeroTel, string password, DateTime dateNaissance, Statut statut, Role role = Role.ReadWrite)
        {
            string motDePasse = EncodeMD5(password);
            Personne user = new Personne() { Nom = nom, Prenom = prenom, Adresse = adresse, Email = email, NumeroTel = numeroTel, Password = motDePasse, DateNaissance= dateNaissance, Role = role, Statut = statut };
            this._bddContext.Personnes.Add(user);
            this._bddContext.SaveChanges();

<<<<<<< Updated upstream
        
=======
            return user;
        }
>>>>>>> Stashed changes
    }
}
