using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewResto.Models;
using NewResto.Models.ViewModels;

namespace NewResto.Controllers
{
    public class AfficherController : Controller
    {
        // GET: Afficher
        public ActionResult Auteurs()
        {

            AfficherViewModels vm = new AfficherViewModels
            {
                Message = "Bonjour",

                ListAuteurs = new List<Auteur>
                 {
                        new Auteur { IdAuteur = 1, NomAuteur = "Senghor" },
                        new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" },
                        new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" }
                 }
            };
            return View(vm);
        }

        public ActionResult Auteur(AccueilViewModels accueilViewModels)
        {

            DAL dal = new DAL();
            int id = 0;
            var LivreParIdAuteur = dal.ListeTousLesLivres_AuteurParID(id);
            accueilViewModels.ListeDesLivres = LivreParIdAuteur.ToList();

            //List<Livre> listDesLivres = dal.ListeTousLesLivres_AuteurParID(accueilViewModels.IdLivre);
            //return View(listDesLivres);
            return View(accueilViewModels);

        }



        /* // GET: Afficher
         public ActionResult Index()
         {
             return View();
         }

         // GET: Afficher/Details/5
         public ActionResult Details(int id)
         {
             return View();
         }

         // GET: Afficher/Create
         public ActionResult Create()
         {
             return View();
         }

         // POST: Afficher/Create
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

         // GET: Afficher/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: Afficher/Edit/5
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

         // GET: Afficher/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: Afficher/Delete/5
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
       *
       */


    }
}