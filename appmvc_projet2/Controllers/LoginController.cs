using appmvc_projet2.Models;
using appmvc_projet2.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace appmvc_projet2.Controllers
{
    public class LoginController : Controller
    {
        public IDal dal;

        public LoginController()
        {
            this.dal = new Dal();
        }

        //Requetes d'authentification

        public ActionResult Connexion()
        {
            UtilisateurViewModel viewModel = new UtilisateurViewModel { Authentifie = HttpContext.User.Identity.IsAuthenticated };
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                viewModel.Personne = dal.ObtenirUtilisateur(userId);
                return Redirect("/Index");
            }
            return View(viewModel);
        }


        [HttpPost]
        //
        public ActionResult Connexion(UtilisateurViewModel viewModel, string returnUrl)
        {
            if (viewModel.Personne.Email != null && viewModel.Personne.Password != null)
            {
                Personne personne = dal.Authentifier(viewModel.Personne.Email, viewModel.Personne.Password);
                if (personne != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Email , personne.Email),
                        new Claim(ClaimTypes.NameIdentifier , personne.Id.ToString()),
                        new Claim(ClaimTypes.Role, personne.Role.ToString()),
                    };

                    var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");

                    var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });
                    HttpContext.SignInAsync(userPrincipal);



                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    return Redirect("/");
                }
                ModelState.AddModelError("Personne.Email", "Email et/ou mot de passe incorrect(s)");
            }
            return View(viewModel);
        }



        //Requetes Creation compte
        public IActionResult CreerCompte()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreerCompte(Personne personne)
        {
            if (ModelState.IsValid)
            {
                Personne userCreated = dal.AjouterUtilisateur(personne.Nom, personne.Prenom, personne.Adresse,
                    personne.Email, personne.NumeroTel, personne.Password, personne.DateNaissance, personne.Statut);

                var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, userCreated.Nom),
                        new Claim(ClaimTypes.Name, userCreated.Prenom),
                        new Claim(ClaimTypes.Name, userCreated.Adresse),
                        new Claim(ClaimTypes.Name, userCreated.Email),
                        new Claim(ClaimTypes.Name, userCreated.NumeroTel),
                        new Claim(ClaimTypes.Name, userCreated.Password),
                          new Claim(ClaimTypes.Name, userCreated.Statut.ToString()),
                        new Claim(ClaimTypes.DateOfBirth, userCreated.DateNaissance.ToString()),
                        new Claim(ClaimTypes.NameIdentifier, userCreated.Id.ToString()),
                        new Claim(ClaimTypes.Role, userCreated.Role.ToString())

                    };

                var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return Redirect("/");
            }
            return View(personne);
        }

        public ActionResult Deconnexion()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }

    }
}
