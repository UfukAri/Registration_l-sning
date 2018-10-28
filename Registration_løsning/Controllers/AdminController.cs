using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Registration_løsning.ViewModel;
using log4net;
using System.Web;
using System.IO;

namespace Registration_løsning.Controllers
{
    public class AdminController : Controller
    {


        DB db = new DB();
        private AdminRepositoryStub adminRepositoryStub;

        //public AdminController(AdminRepositoryStub adminRepositoryStub)
        //{
        //    this.adminRepositoryStub = adminRepositoryStub;
        //}

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
            
            AdminDal slett = new AdminDal();

            slett.SlettFilm(id);
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

            AdminDal admin = new AdminDal();

            if (ModelState.IsValid)
            {

                admin.EditFilm(film);

                return RedirectToAction("FilmListe");
            }

            return View();
        }





        [HttpPost]
        public ActionResult Leggfilm(Film innFilm)
        {
            AdminDal legg = new AdminDal();

            legg.LeggFilm(innFilm);

            return RedirectToAction("FilmListe");

        }

        /*--------------------------------------Kunde----*/

        public ActionResult Register()
        {

            return View();
        }

       
       
        public ActionResult AdminLogIn(string Email, string password)
        {

            if(Email == "Admin@MovieChill.no" && password == "admin123")
            {
                Session["Email"] = Email;
                Session["Firstname"] = "Admin";
                return RedirectToAction("AdminSite");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Slett(int id)
        {
            var Kunde = db.Kunde.SingleOrDefault(b => b.id == id);
            db.Kunde.Remove(Kunde);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }


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

        

        private static log4net.ILog Log { get; set; }

        ILog log = log4net.LogManager.GetLogger(typeof(AdminController));

        public ActionResult Logg()
        {
           
            var fileContents = System.IO.File.ReadAllText(Server.MapPath("~/Views/Admin/Logg.txt"));
            return Content(fileContents);

        }
    }
}