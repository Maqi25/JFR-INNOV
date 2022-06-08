using System;
using System.Collections.Generic;

namespace appmvc_projet2.Models
{
    public interface IDal : IDisposable
    {
        void DeleteCreateDatabase();
        List<Personne> ObtientToutesLesPersonnes();

        Personne ObtenirUtilisateur(int id);
        Personne ObtenirUtilisateur(string userId);
        Personne Authentifier(string Email, string password);

        Personne AjouterUtilisateur(string nom, string prenom, string adresse, string email, string numeroTel, string password, DateTime dateNaissance, Statut statut, Role role = Role.Admin);
    }
}
