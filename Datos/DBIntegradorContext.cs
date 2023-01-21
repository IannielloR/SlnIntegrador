using Entidades;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBIntegradorContext : DbContext
    {
        //Constructor
        public DBIntegradorContext() : base("KeyDB") { }

        //Propiedades DBSET
        /*public DbSet<Clinica> LineasAereas { get; set; }
        public DbSet<Director> Directores { get; set; }
        public DbSet<Enfermero> Enfermeros { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }*/
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        /*public DbSet<PersonaBase> Personas { get; set; }*/
        
    }
}
