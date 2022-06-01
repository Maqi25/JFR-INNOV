using appmvc_projet2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace appmvc_projet2.Controllers
{
    public class PersonneController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        /*[HttpPost]
        public IActionResult ModifierSejour(Personne personne)
        {
            *//*if (!ModelState.IsValid)
                return View(personne);*//*

            if (personne.Id != 0)
            {
                using (Dal dal = new Dal())
                {
                    dal.ModifierPersonne(personne.Id, personne.Nom, personne.Prenom, personne.Adresse, personne.Email, personne.NumeroTel);
                    return RedirectToAction("ModifierPersonne", new { @id = personne.Id });
                }
            }
            else
            {
                return View("Error");
            }
        }*/
        [HttpPost]
        public IActionResult ModifierPersonne(Personne personne)
        {
            if (personne.Id != 0)
            {
                using (Dal dal = new Dal())
                {
                    dal.ModifierPersonne(personne.Id, personne.Nom, personne.Prenom, personne.Adresse, personne.Email, personne.NumeroTel);
                    return RedirectToAction("ModifierPersonne", new { @id = personne.Id });
                }
            }
            return View("Error");
        }


    }

  
}
