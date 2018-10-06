using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration_løsning.Models
{
    public class FilmView
    {

        public List<Film> Action { get; set; }
        public List<Film> Komedie { get; set; }
        public List<Film> Horror { get; set; }
    }
}