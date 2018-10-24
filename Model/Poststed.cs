using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Poststed
    {
        [Key]
        public int Id { get; set; }
        public string PostSted { get; set; }
        public string PostNr { get; set; }
        public virtual List<Kunde> Kunde { get; set; }
    }
}
