using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Codefirst_repaso2.Models
{
    public class AdoContext : DbContext
    {
        public AdoContext()
            :base("DBConection")
        {
            
        }

        public DbSet<Familia> FamiliasSet { get; set; }
        public DbSet<Miembro> MiembrosSet { get; set; }
    }
}