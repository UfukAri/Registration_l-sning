using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public Kunde Kunde { get; set; }
        public Film Film { get; set; }
    }
}
