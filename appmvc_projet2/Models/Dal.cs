using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

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

        public void Dispose()
        {
            _bddContext.Dispose();
        }

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
            Personne user = new Personne() { Nom = nom, Prenom = prenom, Adresse = adresse, Email = email, NumeroTel = numeroTel, Password = motDePasse, DateNaissance = dateNaissance, Role = role, Statut = statut };
            this._bddContext.Personnes.Add(user);
            this._bddContext.SaveChanges();

            return user;
        }
    }
}
