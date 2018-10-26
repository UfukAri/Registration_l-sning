using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Registration_løsning.ViewModel;



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

        public ActionResult Bestillinger()
        {
            // Henter alle ordre 
            var ordre = db.Order.ToList();
            // Liste av orderviewModel
            var orderViewModelListe = new List<OrderViewModel>();
            foreach (var order in ordre)
            {

                // hent kunde 
                var kunde = db.Kunder.Find(order.dbKundeId);
                // hent ordrelinje for hver ordre
                var ordrelinjer = db.OrderLinjes.Where(ol => ol.OrderId == order.Id).ToList();
                // hent filmer til hver ordrelinjer
                foreach (var ol in ordrelinjer)
                {
                    var film = db.Film.Find(ol.FilmId);
                    ol.Film = film;
                }
                var ordreView = new OrderViewModel();
                ordreView.OrderId = order.Id;
                ordreView.Kunde = kunde;
                ordreView.OrderLinjer = ordrelinjer;
                // Legger den til liste
                orderViewModelListe.Add(ordreView);
            }



            return View(orderViewModelListe);
        }

        public ActionResult AdminSite()
        {
            return View();
        }



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



        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Film film = db.Film.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Pris,Catrgory,Discription")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("FilmListe");
            }

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
            var Kunde = db.Kunde.SingleOrDefault(b => b.id == id);
            db.Kunde.Remove(Kunde);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        //public ActionResult HentKunde(int id)
        //{
        //                // hent alle ordre, med dato og antall, som har ordrelinjer som har varer med navnet "Skruer 3mm"

        //    var kunde1 = db.Postsed.Join(db.Kunde,
        //                                                 p => p.Id,
        //                                                 k => k.Id,
        //                                                 (k, p) => new Kunde
        //                                                 {
        //                                                     //PostNr = k.PostNr,
        //                                                     //PostSted = k.PostSted,
        //                                                     Firstname =p.Firstname



        //                                                 })
        //                                                 .Where(Kunde => Kunde.Id == id);


        //    return View();

        //}
        //public ActionResult Endre(int id)
        //{
        //    var db = new DB();
        //    Kunde enKunde = db.HentKunde(id);
        //    return View(enKunde);
        //}

        //[HttpPost]
        //public ActionResult Endre(Kunde innKunde)
        //{
        //    var db = new DB();
        //    bool OK = db.endreKunde(innKunde);
        //    if (OK)
        //    {
        //        return RedirectToAction("Liste");
        //    }
        //    return View();
        //}

        public ActionResult KundeListe()
        {
            List<Model.dbKunde> alleKunder = db.Kunder.ToList();

            return View(alleKunder);
        }

        public ActionResult EditKunde(int id)
        {
            var kunde = db.Kunder.Find(id);

            return View(kunde);
        }


        [HttpPost]
        public ActionResult EditKunde(dbKunde innCostumer, int id)
        {

            using (var db = new DB())
            {
                // hent det ønskede elementet man vil endre
                var usr = db.Kunder.Find(id);
                if (usr.Poststed != null) usr.Poststed = innCostumer.Poststed;
                var usrPoststed = db.Poststed.Find(innCostumer.PoststedId);

                // endre en attributt

                usr.Firstname = innCostumer.Firstname;
                usr.Lastname = innCostumer.Lastname;
                usr.Email = innCostumer.Email;
                usr.PoststedId = innCostumer.PoststedId;
                usr.Poststed.PostSted = innCostumer.Poststed.PostSted;
                usr.Poststed.PostNr = innCostumer.Poststed.PostNr;


                // lagre endringene
                db.SaveChanges();

            }



            return RedirectToAction("KundeListe");
        }

        //public ActionResult EditKunde(int? id)
        //{

        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    Kunde film = db.Kunde.Find(id);
        //    if (film == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult EditKunde([Bind(Include = "Firstname,Lastname,Email,Password,PostSted,PostNr")] Kunde Kunde, Poststed poststed)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(Kunde).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("KundeListe");
        //    }

        //    return View();
        //}
    }
}