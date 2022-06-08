using Microsoft.EntityFrameworkCore;
<<<<<<< Updated upstream
=======
using Microsoft.Extensions.Configuration;
using System;
>>>>>>> Stashed changes

namespace appmvc_projet2.Models
{
    public class BddContext : DbContext
    {
        public DbSet<AideALaPersonne> AideALaPersonnes { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<LocationDeVehicule> LocationDeVehicules { get; set; }
        public DbSet<PersonneInscrite> PersonneInscrites { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<TransportDeColis> TransportDeColis { get; set; }
        public DbSet<TransportDePersonne> TransportDePersonnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=ProjetJFR");
            }
            else
            {
                IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
                optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // specification on configuration

            //declare non nullable columns


            modelBuilder.Entity<Personne>().Property(u => u.Nom).IsRequired();
            modelBuilder.Entity<Personne>().Property(t => t.Prenom).IsRequired();
            modelBuilder.Entity<Personne>().Property(u => u.Email).IsRequired();
            modelBuilder.Entity<Personne>().Property(u => u.Adresse).IsRequired();
            modelBuilder.Entity<Personne>().Property(u => u.NumeroTel).IsRequired();
            modelBuilder.Entity<Personne>().Property(u => u.Statut).IsRequired();
            modelBuilder.Entity<Personne>().Property(u => u.Password).IsRequired();
            modelBuilder.Entity<Personne>().Property(u => u.DateNaissance ).IsRequired();

        }


        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
<<<<<<< Updated upstream
            this.Personnes.AddRange(
=======

            this.Personnes.AddRange (
>>>>>>> Stashed changes
                new Personne
                {
                    Id = 1,
                    Nom = "Ferrie",
                    Prenom = "Fred",
                    Email = "fredferrie@gmail.com",
<<<<<<< Updated upstream
                    Adresse = "10 rue de Paris, Paris",
                    NumeroTel = "123456789"
=======
                    Password = Dal.EncodeMD5("1234567890"),
                    Adresse = "10 rue de Paris, Paris",
                    NumeroTel = "1234567890",
                    Statut = Statut.provider,
                    Role = Role.ReadWrite

>>>>>>> Stashed changes
                },
                new Personne
                {
                    Id = 2,
                    Nom = "Bias",
                    Prenom = "Jules",
                    Email = "julesbias@gmail.com",
                    Adresse = "10 rue de Paris, Grenoble",
<<<<<<< Updated upstream
                    NumeroTel = "7896541213"
=======
                    NumeroTel = "7896541213",
                    DateNaissance = new DateTime(2021, 12, 15),
                    Statut = Statut.provider,
                    Password = Dal.EncodeMD5("1234567890"),
                    Role = Role.ReadOnly
>>>>>>> Stashed changes
                },
                 new Personne //lier la personneid avec la personne inscrite
                 {
                     Id = 3,
                     Nom = "Nguenga",
                     Prenom = "Romuald",
                     Email = "romualdnguengas@gmail.com",
                     Adresse = "10 rue de Paris, Suresnes",
<<<<<<< Updated upstream
                     NumeroTel = "45698712"
=======
                     NumeroTel = "45698712",
                     DateNaissance = new DateTime(2021, 12, 15),
                     Statut = Statut.consummer,
                     Password = Dal.EncodeMD5("1234567890"), 
                     Role = Role.ReadWrite
>>>>>>> Stashed changes
                 }
            );
            this.SaveChanges();
        }


    }
}
