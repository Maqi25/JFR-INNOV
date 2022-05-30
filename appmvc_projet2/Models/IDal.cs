using System;
using System.Collections.Generic;

namespace appmvc_projet2.Models
{
    public interface IDal : IDisposable
    {
        void DeleteCreateDatabase();
        List<PersonneInscrite> ObtientToutessLesPersonneInscrites();
        int CreerPersonneInscrite(string nom, string prenom, string adresse, 
            string email, string numeroTel, string statut);
    }
}
