using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirst_repaso2.Models
{
    public class Miembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdFamilia { get; set; }

        [ForeignKey("IdFamilia")]
        public Familia Familia { get; set; }
    }
}