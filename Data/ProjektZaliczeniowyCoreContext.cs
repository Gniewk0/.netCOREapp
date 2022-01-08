using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektZaliczeniowyCore.Models;

namespace ProjektZaliczeniowyCore.Data
{
    public class ProjektZaliczeniowyCoreContext : DbContext
    {
        public ProjektZaliczeniowyCoreContext (DbContextOptions<ProjektZaliczeniowyCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ProjektZaliczeniowyCore.Models.Event> Event { get; set; }
    }
}
