using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDal : DAL.IAdminRepository
    {
        DB db = new DB();

        public Film EditFilm(Film film)
        {
            string temp = film.Title;
            db.Entry(film).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();



            System.IO.File.WriteAllText(@"C:\Users\jab_a\source\repos\Registration_l-sning\Registration_løsning\Views\Admin\Logg.txt", "Filmen " + temp + " har blitt redigert fra databasen");
            
            return film;
        }

       
        public Film LeggFilm(Film innFilm)
        {
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

            }

            System.IO.File.WriteAllText(@"C:\Users\jab_a\source\repos\Registration_l-sning\Registration_løsning\Views\Admin\Logg.txt", "Filmen " + innFilm.Title + " har blitt lagt til databasen");
            return innFilm;
        }

        public int SlettFilm(int id)
        {
            var film = db.Film.SingleOrDefault(b => b.Id == id);
            db.Film.Remove(film);
            db.SaveChanges();
            System.IO.File.WriteAllText(@"C:\Users\jab_a\source\repos\Registration_l-sning\Registration_løsning\Views\Admin\Logg.txt", "Filmen " + film.Title + " har blitt slettet fra databasen");

            return id;
        }
    }
}
