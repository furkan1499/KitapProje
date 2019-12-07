using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapTakipZinciri.Models
{
    public class book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string authorName { get; set; }
        public double price { get; set; }
        public double discount { get; set; }
        public int edition { get; set; }
        public string ISBN { get; set; }
        public string languages { get; set; }
        public DateTime createDate { get; set; }
        public string size { get; set; }
        public double pageNumber { get; set; }
        public string category { get; set; }
        public string paperQuality{ get; set; }
    }
}
