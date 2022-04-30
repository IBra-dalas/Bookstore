using Microsoft.AspNetCore.Mvc;
using NewResto.Models;
using System.Collections.Generic;
using System.Linq;

namespace NewResto.Controllers
{
    public class AccueilViewModels : Controller
    {
        public List<Livre> ListeDesLivres { get; internal set; }

        private DAL dal = new DAL();

        // GET: Accueil
        public ActionResult Afficher(AccueilViewModels accueilViewModels)
        {

            var meslivres = dal.ListeTousLesLivres();

            accueilViewModels.ListeDesLivres = meslivres.ToList();
            return View(accueilViewModels);
        }


    }
}
