using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration_løsning.Models
{
    public class Poststed
    {
        [Key]
        public int Id { get; set; }
        public string PostSted { get; set; }
        public string PostNr { get; set; }
        public virtual  List<Kunde> Kunde { get; set; }
    }
}