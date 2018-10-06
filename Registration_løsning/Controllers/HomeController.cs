using Registration_løsning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Registration_løsning.Controllers
{
    public class HomeController : Controller
    {

        DB db = new DB();

        

        public ActionResult Index()
        {

            var dbfilm1 = db.Film.Where(f => f.Catrgory == "Komedie").ToList();
            var dbfilm2 = db.Film.Where(f => f.Catrgory == "Action").ToList();
            var dbfilm3 = db.Film.Where(f => f.Catrgory == "Horror").ToList();

            var filmType = new FilmView
            {
                Komedie = dbfilm1,
                Action = dbfilm2,
                Horror = dbfilm3,
            };
            
            return View(filmType);
        }


        public ActionResult Detaljer(int id)
        {
            var filmDb = new DB();
            Film enfilm = filmDb.Film.SingleOrDefault(f => f.Id == id);

            return View(enfilm);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}