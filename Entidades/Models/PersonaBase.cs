using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class PersonaBase
    {

        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        public string Apellido{ get; set; }

        [Column(TypeName = "varchar")]
        public string Domicilio { get; set; }

        [Column(TypeName = "varchar")]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar")]
        public string Email { get; set; }


    }
}
