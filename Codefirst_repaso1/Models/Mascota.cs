using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Codefirst_repaso1.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Animal { get; set; }

        public List<Domador> Domadors { get; set; }
    }
}