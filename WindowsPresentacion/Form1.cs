using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Dac;
using Datos.Migrations;
using Entidades.Models;
using Negocio;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int countMedicoClinico = 0;
            foreach (Medico medico in AdmMedico.Listar())
            {
                if (medico.Especialidad.Equals("Medico Clinico"))
                {
                    medicoClinico.Items.Add(medico.Nombre);
                    countMedicoClinico++;
                }

            }
            medicoClinico.Items.Add($"Cantidad medicos clinicos: {countMedicoClinico}");

            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                string ocupado = "";

                if (habitacion.Estado)
                {
                    ocupado = "Ocupado";
                } else
                {
                    ocupado = "Libre";
                }

                listNumeroHabitacion.Items.Add($"Habitacion: {habitacion.Numero},  {ocupado}");



            }

            MostrarTodosLosMedicos();
            MostrarTodosLosPacientes();

        }

        private void rbtnMedico_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled= true;
            txtDomicilio.Enabled= true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled= true;
            txtEspecialidad.Enabled= true;
            txtMatricula.Enabled= true;
           
        }

        private void rbtnPaciente_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDomicilio.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtEspecialidad.Enabled = false;
            txtMatricula.Enabled = false;
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (rbtnMedico.Checked)
            {
                try
                {
                    id = Convert.ToInt32(txtId.Text);
                    Medico medico = AbmMedicos.SelectWhereById(id);
                    MessageBox.Show(medico.Nombre);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
               
            }
            else if(rbtnPaciente.Checked)
            {
                try
                {
                    id = Convert.ToInt32(txtId.Text);
                    Paciente paciente = AbmPacientes.SelectWhereById(id);
                    MessageBox.Show(paciente.Nombre);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                
            }
            else
            {
                MessageBox.Show("Error no selecciono, si es un panciente o un medico");
            }
            

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = 0;

            if (rbtnMedico.Checked)
            {
                try
                {
                    Medico medico = new Medico() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, Domicilio = txtDomicilio.Text, Telefono = txtTelefono.Text, Email = txtEmail.Text, Especialidad = txtEspecialidad.Text, Matricula = txtMatricula.Text };
                    filasAfectadas = AbmMedicos.Insert(medico);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
            else if (rbtnPaciente.Checked)
            {
                try
                {
                    Paciente paciente = new Paciente() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, Domicilio = txtDomicilio.Text, Telefono = txtTelefono.Text, Email = txtEmail.Text };
                    filasAfectadas = AbmPacientes.Insert(paciente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                
            }
            else
            {
                MessageBox.Show("Error no selecciono, si es un panciente o un medico");
            }

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarTodosLosMedicos();
                MostrarTodosLosPacientes();
            }


        }
        private void MostrarTodosLosPacientes()
        {
            gridPacientes.DataSource = AbmPacientes.SelectAll();
        }

        private void MostrarTodosLosMedicos()
        {
            gridMedico.DataSource = AbmMedicos.SelectAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            int filasAfectadas = 0 ;

            if (rbtnMedico.Checked)
            {
                try
                {
                    Medico medico = new Medico() {MedicoId = Convert.ToInt32(txtId.Text), Nombre = txtNombre.Text, Apellido = txtApellido.Text, Domicilio = txtDomicilio.Text, Telefono = txtTelefono.Text, Email = txtEmail.Text, Especialidad = txtEspecialidad.Text, Matricula = txtMatricula.Text };
                    filasAfectadas = AbmMedicos.Update(medico);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else if (rbtnPaciente.Checked)
            {
                try
                {
                    Paciente paciente = new Paciente() {PacienteId = Convert.ToInt32(txtId.Text), Nombre = txtNombre.Text, Apellido = txtApellido.Text, Domicilio = txtDomicilio.Text, Telefono = txtTelefono.Text, Email = txtEmail.Text };
                    filasAfectadas = AbmPacientes.Update(paciente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                
            }else
            {
                MessageBox.Show("Error no selecciono, si es un panciente o un medico");
            }

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarTodosLosMedicos();
                MostrarTodosLosPacientes();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = 0;

            if (rbtnMedico.Checked)
            {
                try
                {
                    Medico medico = new Medico() { MedicoId = Convert.ToInt32(txtId.Text) };
                    filasAfectadas = AbmMedicos.Delete(medico);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                

            }
            else if (rbtnPaciente.Checked)
            {
                try
                {
                    Paciente paciente = new Paciente() { PacienteId = Convert.ToInt32(txtId.Text) };
                    filasAfectadas = AbmPacientes.Delete(paciente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Error no selecciono, si es un panciente o un medico");
            }

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarTodosLosMedicos();
                MostrarTodosLosPacientes();
            }
        }
    }
}
