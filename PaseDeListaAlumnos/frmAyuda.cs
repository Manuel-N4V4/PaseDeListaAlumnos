using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PaseDeListaAlumnos
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
            cbAsistencia.Items.Add("Asistencia");
            cbAsistencia.Items.Add("Falta");
            cbAsistencia.Items.Add("Retardo");
            cbAsistencia.Items.Add("Justificada");
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}