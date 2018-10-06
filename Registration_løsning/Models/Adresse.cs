using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration_løsning.Models
{
    public class Adresse
    {
        public int Id { get; set; }
        public string PostSted { get; set; }
        public string PostNr { get; set; }
        public List<Kunde> Kunde { get; set; }
    }
}