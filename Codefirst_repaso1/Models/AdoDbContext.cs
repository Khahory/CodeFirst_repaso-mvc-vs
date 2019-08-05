using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Codefirst_repaso1.Models
{
    public class AdoDbContext: DbContext
    {
        public AdoDbContext()
            :base("DBConection")
        {
            
        }

        public DbSet<Domador> Domadores { get; set; }
        public  DbSet<Mascota> Mascotas { get; set; }
        
    }
}