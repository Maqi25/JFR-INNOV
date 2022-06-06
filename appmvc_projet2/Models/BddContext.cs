using appmvc_projet2.Models.Reservations;
using appmvc_projet2.Models.Services;
using appmvc_projet2.Models.Services.AidePersonnes;
using appmvc_projet2.Models.Services.LocationVehicules;
using appmvc_projet2.Models.Services.TransportColis;
using appmvc_projet2.Models.Services.TransportPersonnes;
using Microsoft.EntityFrameworkCore;
using System;


namespace appmvc_projet2.Models
{
    public class BddContext : DbContext
    {
        public DbSet<AideALaPersonne> AideAuxPersonnes { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<LocationDeVehicule> LocationDeVehicules { get; set; }
        public DbSet<PersonneInscrite> PersonneInscrites { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<TransportDeColis> TransportDeColis { get; set; }
        public DbSet<TransportDePersonnes> TransportDePersonnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=2020;database=jfrinnov");
        }

        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();

            this.Personnes.AddRange(
                new Personne
                {
                    Id = 1,
                    Nom = "Ferrie",
                    Prenom = "Fred",
                    DateNaissance = new DateTime(2021, 12, 15),
                    Email = "fredferrie@gmail.com",
                    Password = "fffff",
                    Adresse = "10 rue de Paris, Paris",
                    NumeroTel = "123456789",
                    Statut = "Provider",
                    Role = Role.ReadOnly

                },
                new Personne
                {
                    Id = 2,
                    Nom = "Bias",
                    Prenom = "Jules",
                    Email = "julesbias@gmail.com",
                    Adresse = "10 rue de Paris, Grenoble",
                    NumeroTel = "7896541213",
                    DateNaissance = new DateTime(2021, 12, 15),
                    Statut = "Provider",
                    Password = "fffff",
                    Role = Role.Admin
                },
                 new Personne
                 {
                     Id = 3,
                     Nom = "Nguenga",
                     Prenom = "Romuald",
                     Email = "romualdnguengas@gmail.com",
                     Adresse = "10 rue de Paris, Suresnes",
                     NumeroTel = "45698712",
                     DateNaissance = new DateTime(2021, 12, 15),
                     Statut = "Provider",
                     Password = "fffff",
                     Role = Role.Admin
                 }
            );
            this.SaveChanges();
        }


    }
}
