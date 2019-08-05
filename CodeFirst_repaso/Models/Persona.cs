using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_repaso.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Range(1,90)]
        public int Edad { get; set; }

        public List<Carro> Carros { get; set; }
    }
}