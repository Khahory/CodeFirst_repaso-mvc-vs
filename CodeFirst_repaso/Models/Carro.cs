using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst_repaso.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public int PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        public Persona Persona { get; set; }
    }
}