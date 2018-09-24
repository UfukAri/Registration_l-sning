using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration_løsning.Models;


namespace Registration_løsning.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (OurDbContext db = new OurDbContext())
            {
                return View(db.userAccount.ToList());
            }
        }

        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount account)
        {

            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Firstname + " " + account.Lastname + "Vellykket registrering.";
            }
            return View();
        }

        //Logg inn
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.userAccount.Where(u=> u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
                if (usr != null)
                {

                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();
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


    }
}