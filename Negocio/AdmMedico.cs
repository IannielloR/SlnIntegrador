using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades.Models;

namespace Negocio
{
    public static class AdmMedico
    {
        
        
        public static List<Medico> listaMedico = new List<Medico>();

        public static List<Medico> Listar()
        {
            listaMedico.Add(new Medico() { Nombre = "Rocio", Apellido = "Ianniello", Domicilio = "Av.Siempreviva 123", Telefono = "42433354", Email = "nickorn96@gmail.com", Especialidad = "Medico Clinico", Matricula = "C208734"});
            AbmMedicos.Insert(listaMedico[0]);
            listaMedico.Add(new Medico() { Nombre = "Nicolas", Apellido = "Ramos", Domicilio = "Calle falsa 123", Telefono = "42123354", Email = "pepa@gmail.com",  Especialidad = "Pediatra", Matricula = "C203344" });
            AbmMedicos.Insert(listaMedico[1]);
            listaMedico.Add(new Medico() {  Nombre = "Agustina", Apellido = "Canale", Domicilio = "Corrientes 2000", Telefono = "42343354", Email = "pepito@gmail.com", Especialidad = "Medico Clinico", Matricula = "C204534"});
            AbmMedicos.Insert(listaMedico[2]);
            listaMedico.Add(new Medico() {  Nombre = "Martin", Apellido = "Quiroga", Domicilio = "Cordoba 2323", Telefono = "4246354", Email = "pipon@gmail.com", Especialidad = "Traumatologo", Matricula = "C2057634"});
            AbmMedicos.Insert(listaMedico[3]);
            listaMedico.Add(new Medico() { Nombre = "Samuel", Apellido = "Rivera", Domicilio = "Melo 935", Telefono = "42433454", Email = "pepon@gmail.com",   Especialidad = "TODAS", Matricula = "C2067834"});
            AbmMedicos.Insert(listaMedico[4]);
            //TODO…
            return listaMedico;
        }

        public static List<Medico> Listar(string especialidad)
        {
            
            //TODO…
            return null;

        }
        public static int Insertar(Medico medico)
        {
            //TODO…
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO…
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            //TODO…
            return null;
        }



    }
}
