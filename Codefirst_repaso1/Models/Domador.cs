using System.ComponentModel.DataAnnotations.Schema;

namespace Codefirst_repaso1.Models
{
    public class Domador
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int IdMascota { get; set; }
        [ForeignKey("IdMascota")]
        public Mascota Mascota { get; set; }

    }
}