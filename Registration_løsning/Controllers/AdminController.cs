using Registration_løsning.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;



namespace Registration_løsning.Controllers
{
    public class AdminController : Controller
    {

        DB db = new DB();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }


        // GET: Admin
        public ActionResult Index()
        {
            db = new DB();

            return View();
        }

        public ActionResult AdminSite()
        {
            return View();
        }

        

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

        public ActionResult Edit(Film hent, int id)
        {
            var film = db.Film.SingleOrDefault(b => b.Id == id);

            Film ny = new Film();
            ny.Title = hent.Title;
            ny.Pris = hent.Pris;
            ny.Catrgory = hent.Catrgory;
            ny.Discription = hent.Discription;

            db.Film.Add(hent);
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

        /*--------------------------------------Kunde----*/

        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(Kunde kunde)
        {

            if (ModelState.IsValid)
            {
                using (DB db = new DB())
                {
                    db.Kunde.Add(kunde);
                    db.SaveChanges();
                }
                ModelState.Clear();
            }
            return RedirectToAction("LogIn", "Kunde");



        }

        public ActionResult Slett(int id)
        {
            var Kunde = db.Kunde.SingleOrDefault(b => b.Id == id);
            db.Kunde.Remove(Kunde);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public ActionResult KundeListe()
        {
            List<Models.Kunde> alleKunder = db.Kunde.ToList();

            return View(alleKunder);
        }

        public ActionResult EndreKunde()
        {
            return View();
        }


        [HttpGet]
        public ActionResult EndreKunde(Kunde innCostumer)
        {
            // hent det ønskede elementet man vil endre
            var usr = db.Kunde.Where(u => u.Id == innCostumer.Id).FirstOrDefault();

            // endre en attributt
            Kunde kunde = new Kunde();
            kunde.Firstname = innCostumer.Firstname;
            kunde.Lastname = innCostumer.Lastname;
            kunde.Email = innCostumer.Email;
            kunde.Poststed.PostSted = innCostumer.Poststed.PostSted;
            kunde.Poststed.PostNr = innCostumer.Poststed.PostNr;

            kunde.Password = innCostumer.Password;

            // lagre endringene
            db.Kunde.Add(kunde);
            db.SaveChanges();



            return RedirectToAction("Liste");
        }

    }
}