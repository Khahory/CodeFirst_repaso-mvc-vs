using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst_repaso.Models
{
    public class DbContextApp : DbContext
    {
        public DbContextApp()
            :base("DBConection")
        {
            
        }

        public DbSet<Persona> PersonaSet { get; set; }
        public DbSet<Carro> Carros { get; set; }
    }
}