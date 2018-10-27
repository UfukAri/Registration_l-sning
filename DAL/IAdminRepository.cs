using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAdminRepository
    {
        Film EditFilm(Film film);
        Film LeggFilm(Film film);
        int SlettFilm(int id);
    }
}
