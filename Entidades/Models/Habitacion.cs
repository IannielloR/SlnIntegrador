using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Habitacion
    {      
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        public int Numero { get; set; }

        [Column(TypeName = "varchar")]
        public bool Estado { get; set; }
    }
}
