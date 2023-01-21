using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Dac
{
    public static class AbmPacientes
    {

        private static DBIntegradorContext context = new DBIntegradorContext();
        public static List<Paciente> SelectAll()
        {

            return context.Pacientes.ToList();

        }
        public static Paciente SelectWhereById(int id)
        {

            return context.Pacientes.Find(id);

        }

        public static int Insert(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return context.SaveChanges();

        }

        public static int Update(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente.PacienteId);
            if (pacienteOrigen != null)
            {
                pacienteOrigen.Nombre = paciente.Nombre;
                pacienteOrigen.Apellido = paciente.Apellido;
                pacienteOrigen.Domicilio = paciente.Domicilio;
                pacienteOrigen.Telefono = paciente.Telefono;
                pacienteOrigen.Email = paciente.Email;

            }

            return context.SaveChanges();
        }

        public static int Delete(Paciente medico)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(medico.PacienteId);
            if (pacienteOrigen != null)
            {
                context.Pacientes.Remove(pacienteOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}