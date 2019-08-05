using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst_repaso2.Models
{
    public class Familia
    {
        public int Id { get; set; }
        public string Apellido { get; set; }

        public List<Miembro> Miembros { get; set; }
    }
}