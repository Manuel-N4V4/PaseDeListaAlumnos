using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaseDeListaAlumnos
{
    public partial class frmAlumno : Form
    {
        Conexion conexion = new Conexion();
        int id = 0;
        bool update = false;
        public frmAlumno()
        {
            InitializeComponent();
            cbCarrera.Items.Add("Sistemas computacionales");
            cbCarrera.Items.Add("Gestion empresarial");
            cbCarrera.Items.Add("Electronica");
            cbCarrera.Items.Add("Quimica");
            cbCarrera.Items.Add("Electrica");
            cbCarrera.Items.Add("Mecanica");
            cbCarrera.Items.Add("Energias renovables");
            cbCarrera.Items.Add("Semiconductores");
            cbCarrera.Items.Add("Administracion");
        }
        public frmAlumno(int id, string noControl, string nombre, string carrera)
        {
            InitializeComponent();
            this.id = id;
            cbCarrera.Text = carrera;
            txtNombre.Text = nombre;
            txtNoControl.Text = noControl;
            update = true;
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                bool resultado = conexion.ejecutarComando($"INSERT INTO alumnos (no_control, nombre, carrera) VALUES ('{txtNoControl.Text}', '{txtNombre.Text}', '{cbCarrera.Text}')");
                if (resultado == true)
                {
                    MessageBox.Show("Alumno registrado correctamente");
                    txtNoControl.Clear();
                    txtNombre.Clear();
                    cbCarrera.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error al registrar alumno");
                }
            }
            else
            {
                bool resultado = conexion.ejecutarComando($"UPDATE alumnos SET no_control = '{txtNoControl.Text}', nombre = '{txtNombre.Text}', carrera = '{cbCarrera.Text}' WHERE id = {id}");
                if (resultado == true)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar alumno");

                }
            }
        }
        // Cancelamos el registro del alumno y cerramos el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
