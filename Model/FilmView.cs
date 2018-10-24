using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FilmView
    {
        public List<Film> Action { get; set; }
        public List<Film> Komedie { get; set; }
        public List<Film> Horror { get; set; }
    }
}
