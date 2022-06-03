using System;
using System.Collections.Generic;

namespace appmvc_projet2.Models
{
    public interface IDal : IDisposable
    {
        //void DeleteCreateDatabase();
        List<PersonneInscrite> ObtientToutessLesPersonneInscrites();
        List<Personne> ObtientToutesLesPersonnes();

        void ModifierPersonne(int id, string nom, string prenom, string adresse,
            string email, string numeroTel);
        int CreerPersonneInscrite(int personneId,string statut);
        int CreerPersonne(string nom, string prenom, string adresse,
            string email, string numeroTel);
    }
}
