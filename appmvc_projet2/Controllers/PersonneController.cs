using appmvc_projet2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace appmvc_projet2.Controllers
{
    public class PersonneController : Controller
    {
        public IActionResult ListePersonnes()
        {
            using (Dal dal = new Dal())
            {
                List<Personne> personnes = dal.ObtientToutesLesPersonnes();
                if (personnes == null)
                {
                    return View("Error");
                }
                return View(personnes);
            }
        }

        public IActionResult ModifierPersonne(int id)
        {
            if (id != 0)
            {
                using (Dal dal = new Dal())
                {
                    Personne personne = dal.ObtientToutesLesPersonnes().Where(p => p.Id == id).FirstOrDefault();
                    if (personne == null)
                    {
                        return View("Error");
                    }
                    return View(personne);
                }
            }
            return View("Error");
        }

        
        [HttpPost]
        public IActionResult ModifierPersonne(Personne personne)
        {
            if (personne.Id != 0)
            {
                using (Dal dal = new Dal())
                {
                    dal.ModifierPersonne(personne);
                    return RedirectToAction("ModifierPersonne", new { @id = personne.Id });
                }
            }
            return View("Error");
        }


    }

  
}
