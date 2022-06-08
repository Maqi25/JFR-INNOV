using appmvc_projet2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appmvc_projet2.ViewModels
{
    public class UtilisateurViewModel
    {
        public Personne Personne { get; set; }
        public bool Authentifie { get; set; }
    }
}
