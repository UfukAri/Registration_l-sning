using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Registration_løsning.Models;


namespace Registration_løsning.Controllers
{
    public class BestillingController : Controller
    {
        // init database
        DB db;

        public BestillingController()
        {
            db = new DB();

        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }


        public ActionResult Bestilling()
        {

            return View();

        }



        [HttpPost]
        public ActionResult Bestilling(Order innOrder)
        {

            Order order = new Order();
            order.Film = innOrder.Film;
            order.Kunde = innOrder.Kunde;


            db.Order.Add(order);
            db.SaveChanges();



            return RedirectToAction("Order");

        }

        public ActionResult Order()
        {
            List<Models.Order> alleOrder = db.Order.ToList();

            return View(alleOrder);
        }



        /*--------------------------------------------------------------------------*/
        public ActionResult FilmListe()
        {
            List<Models.Film> alleFilmer = db.Film.ToList();

            return View(alleFilmer);
        }

        public ActionResult Leggfilm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Leggfilm(Film innFilm)
        {
            // Sjekk hvis kunden eksisterer 

            var dbFilm = db.Film.SingleOrDefault(k => k.Title == innFilm.Title);

            if (dbFilm == null)
            {
                Film film = new Film();
                film.Title = innFilm.Title;
                film.Pris = innFilm.Pris;
                film.Catrgory = innFilm.Catrgory;
                film.Discription = innFilm.Discription;

                db.Film.Add(film);
                db.SaveChanges();

                return RedirectToAction("FilmListe");
            }

            return RedirectToAction("FilmListe");

        }
    }
}
