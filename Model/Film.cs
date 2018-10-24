using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pris { get; set; }
        public string Catrgory { get; set; }
        public List<Order> Order { get; set; }
        public string Discription { get; set; }
        public string Image { get; set; }
    }
}
