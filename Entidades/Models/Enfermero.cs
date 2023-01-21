using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Enfermero 
    {

        public int EnfermeroId { get; set; }

        [Column(TypeName = "varchar")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar")]
        public string Domicilio { get; set; }

        [Column(TypeName = "varchar")]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        public int Cuil { get; set; }

    }

}
