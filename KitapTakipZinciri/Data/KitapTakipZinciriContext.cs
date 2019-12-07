using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KitapTakipZinciri.Models;

namespace KitapTakipZinciri.Models
{
    public class KitapTakipZinciriContext : DbContext
    {
        public KitapTakipZinciriContext (DbContextOptions<KitapTakipZinciriContext> options)
            : base(options)
        {
        }

        public DbSet<KitapTakipZinciri.Models.book> book { get; set; }

        public DbSet<KitapTakipZinciri.Models.author> author { get; set; }
    }
}
