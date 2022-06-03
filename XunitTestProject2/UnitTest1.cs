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
               // dal.DeleteCreateDatabase();
                // Nous créons une personne

                int id = dal.CreerPersonne("joe","jack","5bis ananas paris","joejack@gmail.com","0907030506");
                dal.CreerPersonneInscrite(id,"provider");

                // Nous vérifions que la personne a bien été créée
                List<PersonneInscrite> personneInscrites = dal.ObtientToutessLesPersonneInscrites();
                Assert.NotNull(personneInscrites);
                Assert.Single(personneInscrites);
               
                Assert.Equal("provider", personneInscrites[0].Statut);
            }
        }
    }
}
