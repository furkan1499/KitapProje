using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapTakipZinciri.Models
{
    public class route
    {
        public int id { get; set; }

        public string fromCity { get; set; }
        public string toCity { get; set; }
        public double distance { get; set; }
        public DateTime createDate { get; set; }
        public double transportTime { get; set; }
        public double amount { get; set; }
    }
}
