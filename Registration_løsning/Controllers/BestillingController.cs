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

        public ActionResult SlettFilm(int id)
        {
            var film = db.Film.SingleOrDefault(b => b.Id == id);
            db.Film.Remove(film);
            db.SaveChanges();
            return RedirectToAction("FilmListe");
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
                film.Image = innFilm.Image;

                db.Film.Add(film);
                db.SaveChanges();

                return RedirectToAction("FilmListe");
            }

            return RedirectToAction("FilmListe");

        }


        public ActionResult Handelkurve()
        {
            List<Film> filmer = new List<Film>();
            if (Session["handelKurv"] != null)
            {
                filmer = (List<Film>)Session["handelKurv"];
            }

            return View(filmer);
        }


        public ActionResult Bestill(int id)
        {
            var nyFilm = db.Film.SingleOrDefault(f => f.Id == id);

            if (Session["handelKurv"] == null)
            {
                List<Film> filmer = new List<Film>();
                filmer.Add(nyFilm);
                Session["handelKurv"] = filmer;
                Session["Antall"] = filmer.Count;

            }
            else
            {
                List<Film> filmer = (List<Film>)Session["handelKurv"];
                filmer.Add(nyFilm);
                Session["handelKurv"] = filmer;
                Session["Antall"] = filmer.Count;
            }


            return RedirectToAction("Handelkurve", nyFilm);


        }


        public ActionResult Betal()
        {
            return View();
        }


        

        public ActionResult SlettFilmFraHandelkurve(int id)
        {
            var filmer = (List<Film>)Session["handelKurv"];
            foreach (var film in filmer.ToList())
            {
                if (film.Id == id)
                {

                    filmer.Remove(film);
                }
            }
            Session["handelKurv"] = filmer;


            return RedirectToAction("HandelKurve");


        }
    }
}
