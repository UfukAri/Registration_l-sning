
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration_løsning.Models;

namespace Registration_løsning.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public Kunde Kunde { get; set; }
        public Film Film { get; set; }
        public int KundeId { get; set; }
        public int FilmId { get; set; }


        public Order(Film film, Kunde kunde)
        {
            Film = film;
            Kunde = kunde;

        }
        public Order() { }

    }


}