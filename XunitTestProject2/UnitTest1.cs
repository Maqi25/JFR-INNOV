using appmvc_projet2.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XunitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Creation_PersonneInscrites_Verification()
        {
            // Nous supprimons la base si elle existe puis nous la créons
            using (Dal dal = new Dal())
            {
                // Nous supprimons et créons la db avant le test
                dal.DeleteCreateDatabase();
                // Nous créons une personne
                dal.CreerPersonneInscrite("Dupont", "Joe", "10 rue de Paris", "joedupont@gamil.com", "0123456789", "provider");

                // Nous vérifions que la personne a bien été créée
                List<PersonneInscrite> personneInscrites = dal.ObtientToutessLesPersonneInscrites();
                Assert.NotNull(personneInscrites);
                Assert.Single(personneInscrites);
                Assert.Equal("Dupont", personneInscrites[0].Nom);
                Assert.Equal("Joe", personneInscrites[0].Prenom);
                Assert.Equal("10 rue de Paris", personneInscrites[0].Adresse);
                Assert.Equal("joedupont@gamil.com", personneInscrites[0].Email);
                Assert.Equal("0123456789", personneInscrites[0].NumeroTel);
                Assert.Equal("provider", personneInscrites[0].Statut);
            }
        }
    }
}
