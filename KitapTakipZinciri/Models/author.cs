using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapTakipZinciri.Models
{
    public class author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthday { get; set; }
        public int bookId { get; set; }
        public book book { get; set; }
        public string description { get; set; }
    }
}
