﻿using System;

namespace appmvc_projet2.Models
{
    public class Employe 
    {
        public int Id { get; set; }

        public int? PersonneId { get; set; }

        public Personne Personne { get; set; }
        public string Matricule { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string Fonction { get; set; }    
    }
}
