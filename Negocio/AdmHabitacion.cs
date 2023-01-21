using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            List<Habitacion> listaHabitacion = new List<Habitacion>();
            listaHabitacion.Add(new Habitacion() { Id = 1, Numero = 134, Estado = true });
            listaHabitacion.Add(new Habitacion() { Id = 2, Numero = 20, Estado = false });
            listaHabitacion.Add(new Habitacion() { Id = 3, Numero = 394, Estado = true });
            listaHabitacion.Add(new Habitacion() { Id = 4, Numero = 100, Estado = false });
            listaHabitacion.Add(new Habitacion() { Id = 5, Numero = 10, Estado = true });

            return listaHabitacion;
        }

        public static List<Habitacion> Listar(string estado)
        {
            //TODO…
            return null;

        }
        public static int Insertar(Habitacion Habitacion)
        {
            //TODO…
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO…
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            //TODO…
            return null;
        }

    }
}
