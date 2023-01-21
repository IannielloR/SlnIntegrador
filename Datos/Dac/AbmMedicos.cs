using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class AbmMedicos
    {

        private static DBIntegradorContext context = new DBIntegradorContext();
        public static List<Medico> SelectAll()
        {

            return context.Medicos.ToList();

        }
        public static Medico SelectWhereById(int id)
        {

            return context.Medicos.Find(id);

        }

        public static int Insert(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();

        }

        public static int Update(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.MedicoId);
            if (medicoOrigen != null)
            {
                medicoOrigen.Nombre = medico.Nombre;
                medicoOrigen.Apellido = medico.Apellido;
                medicoOrigen.Domicilio = medico.Domicilio;
                medicoOrigen.Telefono = medico.Telefono;
                medicoOrigen.Email = medico.Email;
                medicoOrigen.Especialidad = medico.Especialidad;
                medicoOrigen.Matricula = medico.Matricula;
            }

            return context.SaveChanges();
        }

        public static int Delete(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.MedicoId);
            if (medicoOrigen != null)
            {
                context.Medicos.Remove(medicoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }

    }
}
