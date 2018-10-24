using Registration_løsning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration_løsning.Controllers
{
    public class KundeController : Controller
    {
        

        // GET: Kunde
        public ActionResult Liste()
        {
            using (DB db = new DB())
            {
                return View(db.Kunde.ToList());
            }
        }

        DB db;

        public KundeController()
        {
            db = new DB();

        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }



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
        // Denne laghash-metoden fungerer ikke, dette vil blir prioritert i neste oblig oppgave
        private static byte[] lagHash(string innPassord)
        {
            byte[] innData, utData;
            var algoritme = System.Security.Cryptography.SHA256.Create();
            innData = System.Text.Encoding.ASCII.GetBytes(innPassord);
            utData = algoritme.ComputeHash(innData);
            return utData;
        }

        private static bool bruker_i_db(Kunde innbruker) 
        {
            using (var db = new OurDbContext())
            {
                byte[] passordDB = lagHash(innbruker.Password);
                dbKunde funnetBruker = db.Brukere.FirstOrDefault(
                    b => b.Password == passordDB && b.Id == innbruker.Id);
                if(funnetBruker == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        public ActionResult Slett(int id)
        {
            var Kunde = db.Kunde.SingleOrDefault(b => b.Id == id);
            db.Kunde.Remove(Kunde);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }


        public ActionResult LogIn()
        {
            return View();
        }

        //Login
        //[HttpPost]
        //public ActionResult LogIn(Kunde innBruker)
        //{

        //    if (bruker_i_db(innBruker))
        //    {
        //        Session["LoggetInn"] = true;
        //        return View();
        //    }
        //    else
        //    {
        //        Session["LoggetInn"] = false;
        //        return View();
        //    }
        //}

        [HttpPost]
        public ActionResult LogIn(Kunde user)
        {
            using (DB db = new DB())
            {
                var usr = db.Kunde.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
            if (usr != null)
                {

                    Session["UserID"] = usr.Id.ToString();
                    Session["Email"] = usr.Email.ToString();
                    Session["Passord"] = usr.Password.ToString();
                    Session["Firstname"] = usr.Firstname.ToString();
                    Session["Lastname"] = usr.Lastname.ToString();
                    Session["Email"] = usr.Email.ToString();
                    Session["Poststed"] = usr.Poststed.PostSted.ToString();
                    Session["Postnr"] = usr.Poststed.PostNr.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {

                    ModelState.AddModelError("", "Brukernavn eller passord er feil.");
                }
        }
            return View();

        }

        public ActionResult MinSide()
        {
            return View();
        }



        public ActionResult EditKunde(int id)
        {
            var usr = db.Kunde.Find(id);
            return View(usr);
        }


        [HttpPost]
        public ActionResult EditKunde(Kunde innCostumer, int id)
        {
            // hent det ønskede elementet man vil endre
            var usr = db.Kunde.Where(u => u.Id == innCostumer.Id).FirstOrDefault();
            var innCustomerPoststed = db.Poststed.Find(innCostumer.PoststedId);

            // endre en attributt

            usr.Firstname = innCostumer.Firstname;
            usr.Lastname = innCostumer.Lastname;
            usr.Email = innCostumer.Email;
            usr.PoststedId = innCostumer.PoststedId;
            usr.Poststed.PostSted = innCustomerPoststed.PostSted;
            usr.Poststed.PostNr = innCustomerPoststed.PostNr;

            usr.Password = innCostumer.Password;

            // lagre endringene
            db.SaveChanges();



            return RedirectToAction("KundeListe");
        }

        public ActionResult LoggedIn()
        {
            if ((string)Session["Email"] == "Admin1@MovieChill.no")
            {
                return RedirectToAction("AdminSite", "Admin");
            }
            else if (Session["UserId"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login");
            }

        }

        public ActionResult Logout()
        {

            Session.RemoveAll();
            return RedirectToAction("LogIn", "Kunde");

        }

        public JsonResult CheckUsernameAvailability(String userdata)
        {
            DB db = new DB();

            System.Threading.Thread.Sleep(200);
            var searchData = db.Kunde.Where(x => x.Email == userdata).SingleOrDefault();
            if(searchData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }
        


    }
}