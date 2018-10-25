using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DAL;
using Model;


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


        //public ActionResult Bestilling()
        //{

        //    return View();

        //}



        //[HttpPost]
        //public ActionResult Bestilling(Order innOrder)
        //{

        //    Order order = new Order();
        //    order.Film = innOrder.Film;
        //    order.Kunde = innOrder.Kunde;


        //    db.Order.Add(order);
        //    db.SaveChanges();



        //    return RedirectToAction("Order");

        //}



        public ActionResult Order()
        {
            List<Model.Order> alleOrder = db.Order.ToList();

            return View(alleOrder);
        }



        /*--------------------------------------------------------------------------*/
        public ActionResult FilmListe()
        {
            List<Model.Film> alleFilmer = db.Film.ToList();

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
        //Legger kjøpt film til ordre og ordrelinje tabellen. 
        public ActionResult LeggFilmtilOrder()
        {
            var filmer = (List<Film>)Session["handelKurv"];
            // henter kunden
            int id = Convert.ToInt32(Session["UserID"]);
            var kunde = db.Kunder.Find(id);

            // Lager ordre
            var order = new Order();


            List<OrderLinje> ordrelinjer = new List<OrderLinje>();
            // Lager ordrelinjer 
            foreach (var film in filmer)
            {
                var ordrelinje = new OrderLinje();
                ordrelinje.FilmId = film.Id;
                ordrelinje.OrderId = order.Id;
                ordrelinjer.Add(ordrelinje);
            }

            // Lenker ordre og ordrelinje 

            order.OrdreLinjer = ordrelinjer;
            order.dbKundeId = kunde.Id;

            // Lenker kunde og ordre

            // Her sjekkes hvis kunde har ordre fra f?r 
            if (kunde.Ordrer != null)
            {
                kunde.Ordrer.Add(order);
            }
            else
            {
                // lager ny liste 
                List<Order> ordreListe = new List<Order>();
                ordreListe.Add(order);
                kunde.Ordrer = ordreListe;
            }


            // lagre endringen
            db.SaveChanges();


            Session["handelKurv"] = null;


            return RedirectToAction("Index", "Home");
        }

    }
}
