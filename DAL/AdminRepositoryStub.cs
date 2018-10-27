using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class AdminRepositoryStub : DAL.IAdminRepository
    {
        public Film EditFilm(Film film)
        {
            if (film.Id == 0)
            {
                var test = new Film();
                test.Id = 0;
                return test;
            }
            else
            {
                return film;
            }
          
        }

        public Film LeggFilm(Film film)
        {
            if (film.Id == 0)
            {
                var test = new Film();
                test.Id = 0;
                return test;
            }
            else
            {
                return film;
            }
        }

        public int SlettFilm(int id)
        {
            if (id == 0)
            {
                var film = new Film();
                return film.Id = 0;
            }
            else
            {
                return id;
            }
        }
    }
}
