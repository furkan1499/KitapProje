using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapTakipZinciri.Models
{
    public class transportationCompany
    {
        public int id { get; set; }
        public int routeId { get; set; }
        public route route { get; set; }
        public int bookId { get; set; }
        public book book { get; set; }
    }
}
