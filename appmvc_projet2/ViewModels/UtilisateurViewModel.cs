using appmvc_projet2.Models;
using Microsoft.AspNetCore.Mvc;

namespace appmvc_projet2.ViewModels
{
    public class UtilisateurViewModel
    {
        public Personne Personne { get; set; }
        public bool Authentifie { get; set; }
    }
}
