using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewResto.Models;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using JsonResult = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace NewResto.Controllers
{
    public class CreateLivreController : System.Web.Mvc.Controller
    {
        // GET: CreateLivre
        [HttpPost]
        public IActionResult Ajouter(Livre livre)
        {

            using (IDAL dal = new DAL())
            {
                BddContext bdd = new BddContext();
                if (!ModelState.IsValid)

                {
                   Livre LIVRES = dal.CreerUnLivre(livre.TitreLivre, livre.DateParition, livre.UnAuteur.IdAuteur);
                    ViewBag.Message = "Ajout effectué ";
                
                    return (IActionResult)View(LIVRES);
                }
                else
                {
                    return (IActionResult)View();
                }
                
                  
               
               
                
            }


        }
       

        [HttpGet]
        public IActionResult Index()
        {

            using (IDAL dal = new DAL())
            {
                var v = new Livre();
                return (IActionResult)View(v);
            }


        }

        public List<Auteur> ListAuteurs = new List<Auteur>
        {
            new Auteur { IdAuteur = 1, NomAuteur = "Senghor" },
            new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" },
            new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" }
        };

        public JsonResult VerifNomLivre(string titreLivreVerif)
        {
            IDAL dal = new DAL();
            bool resultat = !dal.LivreExiste(titreLivreVerif);
            return JsonResult(resultat, JsonRequestBehavior.AllowGet);
        }

        private JsonResult JsonResult(bool resultat, JsonRequestBehavior allowGet)
        {
            throw new NotImplementedException();
        }

        /* // GET: CreateLivre
         public ActionResult Index()
         {
             return View();
         }

         // GET: CreateLivre/Details/5
         public ActionResult Details(int id)
         {
             return View();
         }

         // GET: CreateLivre/Create
         public ActionResult Create()
         {
             return View();
         }

         // POST: CreateLivre/Create
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Create(IFormCollection collection)
         {
             try
             {
                 // TODO: Add insert logic here

                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: CreateLivre/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: CreateLivre/Edit/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Edit(int id, IFormCollection collection)
         {
             try
             {
                 // TODO: Add update logic here

                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: CreateLivre/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: CreateLivre/Delete/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Delete(int id, IFormCollection collection)
         {
             try
             {
                 // TODO: Add delete logic here

                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }
      */
    }
}