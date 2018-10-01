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
                ViewBag.Message = kunde.Firstname + " " + kunde.Lastname + "successfully registered.";
            }
            return View();
        }

        public ActionResult Slett(int id)
        {
            var Kunde = db.Kunde.SingleOrDefault(b => b.Id == id);
            db.Kunde.Remove(Kunde);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        //Login
        public ActionResult LogIn()
        {

            return View();
        }

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
                    return RedirectToAction("LoggedIn");
                }
                else
                {

                    ModelState.AddModelError("", "Brukernavn eller passord er feil.");
                }
            }
            return View();

        }
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
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


    }
}