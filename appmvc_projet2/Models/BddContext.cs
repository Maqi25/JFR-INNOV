using Microsoft.EntityFrameworkCore;

namespace appmvc_projet2.Models
{
    public class BddContext : DbContext
    {
        public DbSet<AideALaPersonne> AideALaPersonnes { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<LocationDeVehicule> LocationDeVehicules { get; set; }
        public DbSet<PersonneInscrite> PersonneInscrites { get; set; }

        public DbSet<TransportDeColis> TransportDeColis { get; set; }
        public DbSet<TransportDePersonne> TransportDePersonnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=Sirius25@;database=jfrtestunit");
        }

    }
}
