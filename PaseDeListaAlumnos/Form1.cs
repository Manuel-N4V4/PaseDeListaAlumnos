using MySqlConnector;
using System.Data;

namespace PaseDeListaAlumnos
{
    
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Asistencia");
            comboBox1.Items.Add("Falta");
            comboBox1.Items.Add("Retardo");
            comboBox1.Items.Add("Justificada");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = conexion.ejecutar($"SELECT * FROM alumnos WHERE nombre LIKE '{txtNumControl.Text}%'");
            if (ds != null)
            {
                dgvListaAlumnos.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumControl.Text == "")
            {
                MessageBox.Show("El campo de Núm. de control debe contener información", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime ahora = DateTime.Now;

                DataSet existe = conexion.ejecutar(
                    $"SELECT * FROM asistencia WHERE no_control = '{txtNumControl.Text}' AND fecha = '{ahora.Date.ToString("yyyy-MM-dd")}'"
                );

                if (existe != null && existe.Tables[0].Rows.Count > 0)
                {
                    MySqlCommand cmdUpdate = new MySqlCommand(
                        "UPDATE asistencia SET estado = @estado, fecha = @fecha, hora = @hora WHERE no_control = @no_control AND fecha = @fecha_filtro"
                    );

                    cmdUpdate.Parameters.AddWithValue("@no_control", txtNumControl.Text);
                    cmdUpdate.Parameters.AddWithValue("@fecha", ahora.Date);
                    cmdUpdate.Parameters.AddWithValue("@hora", ahora.TimeOfDay);
                    cmdUpdate.Parameters.AddWithValue("@fecha_filtro", ahora.Date);

                    if (comboBox1.Text == "")
                    {
                        cmdUpdate.Parameters.AddWithValue("@estado", "Asistencia");
                    }
                    else
                    {
                        cmdUpdate.Parameters.AddWithValue("@estado", comboBox1.Text);
                    }

                    bool actualizado = conexion.ejecutarComando(cmdUpdate);

                    if (actualizado == true)
                    {
                        MessageBox.Show("Asistencia ACTUALIZADA correctamente");
                        txtNumControl.Clear();
                        comboBox1.SelectedIndex = -1;
                        txtNumControl.Focus();
                    }
                    dgvListaAlumnos.DataSource = conexion.ejecutar("SELECT * FROM asistencia WHERE fecha = CURDATE()").Tables[0];
                    return;
                }

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO asistencia (no_control, fecha, hora, estado) VALUES (@no_control, @fecha, @hora, @estado)"
                );

                if (comboBox1.Text == "")
                {   
                    cmd.Parameters.AddWithValue("@no_control", txtNumControl.Text);
                    cmd.Parameters.AddWithValue("@fecha", ahora.Date);
                    cmd.Parameters.AddWithValue("@hora", ahora.TimeOfDay);
                    cmd.Parameters.AddWithValue("@estado", "Asistencia");
                }
                else
                { 
                    cmd.Parameters.AddWithValue("@no_control", txtNumControl.Text);
                    cmd.Parameters.AddWithValue("@fecha", ahora.Date);
                    cmd.Parameters.AddWithValue("@hora", ahora.TimeOfDay);
                    cmd.Parameters.AddWithValue("@estado", comboBox1.Text);
                }

                bool resultado = conexion.ejecutarComando(cmd);

                if (resultado == true)
                {
                    MessageBox.Show("Asistencia registrada correctamente");

                    txtNumControl.Clear();
                    comboBox1.SelectedIndex = -1;
                    txtNumControl.Focus();
                }
                else
                {
                    MessageBox.Show("Error al registrar la asistencia");
                }
            }

            DataSet ds = conexion.ejecutar("SELECT * FROM asistencia WHERE fecha = CURDATE()");
            dgvListaAlumnos.DataSource = ds.Tables[0];


            //if (txtNumControl.Text == "")
            //{
            //    MessageBox.Show("El campo de Núm. de control debe contener información", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    string fecha = DateTime.Now.ToString("yyyy-MM-dd");

            //    DataSet existe = conexion.ejecutar(
            //        $"SELECT * FROM asistencia WHERE no_control = '{txtNumControl.Text}' AND fecha = '{fecha}'"
            //    );

            //    if (existe != null && existe.Tables[0].Rows.Count > 0)
            //    {
            //        MessageBox.Show("Este alumno ya tiene asistencia registrada hoy");

            //        txtNumControl.Clear();
            //        txtNumControl.Focus();
            //        return;
            //    }



            //    // Utilizamos MySqlCommand para mandar instruccion de insertado a la base de datos, en la funcion ejecutarComando() de la clase Conexion se asigna la conexion al comando y se ejecuta
            //    MySqlCommand cmd = new MySqlCommand(
            //        "INSERT INTO asistencia (no_control, fecha, hora, estado) VALUES (@no_control, @fecha, @hora, @estado)"
            //    );

            //    DateTime ahora = DateTime.Now;

            //    if (comboBox1.Text == "")
            //    {
            //        // Comandos parametrizados para evitar inyeccion sql    
            //        cmd.Parameters.AddWithValue("@no_control", txtNumControl.Text);
            //        cmd.Parameters.AddWithValue("@fecha", ahora.Date); // Obtenemos la fecha con .Date para eliminar la parte de la hora
            //        cmd.Parameters.AddWithValue("@hora", ahora.TimeOfDay); // Obtenemos solo la parte de la hora con .TimeOfDay
            //        cmd.Parameters.AddWithValue("@estado", "Asistencia");
            //    }
            //    else
            //    {
            //        // Comandos parametrizados para evitar inyeccion sql    
            //        cmd.Parameters.AddWithValue("@no_control", txtNumControl.Text);
            //        cmd.Parameters.AddWithValue("@fecha", ahora.Date); // Obtenemos la fecha con .Date para eliminar la parte de la hora
            //        cmd.Parameters.AddWithValue("@hora", ahora.TimeOfDay); // Obtenemos solo la parte de la hora con .TimeOfDay
            //        cmd.Parameters.AddWithValue("@estado", comboBox1.Text);
            //    }

            //    bool resultado = conexion.ejecutarComando(cmd);

            //    if (resultado == true)
            //    {
            //        MessageBox.Show("Asistencia registrada correctamente");

            //        // Limpiar controles
            //        txtNumControl.Clear();
            //        comboBox1.SelectedIndex = -1;
            //        txtNumControl.Focus();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al registrar la asistencia");
            //    }
            //}
            //DataSet ds = conexion.ejecutar("SELECT * FROM asistencia");
            //dgvListaAlumnos.DataSource = ds.Tables[0];

        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            frmAlumno alummno = new frmAlumno();
            alummno.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNumControl.Text == "")
            {
                MessageBox.Show("El campo de Núm. de control debe contener información", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbAsistencia.Checked == true)
                {
                    DataSet resultado = conexion.ejecutar($"SELECT * FROM asistencia WHERE no_control = '{txtNumControl.Text}'");
                    if (resultado != null)
                    {
                        dgvListaAlumnos.DataSource = resultado.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos de asistencias");
                    }
                }
                if (rbAlumno.Checked == true)
                {
                    DataSet resultado = conexion.ejecutar($"SELECT * FROM alumnos WHERE no_control = '{txtNumControl.Text}'");
                    if (resultado != null)
                    {
                        dgvListaAlumnos.DataSource = resultado.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos de los alumnos");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbAsistencia.Checked)
            {
                if (txtNumControl.Text == "")
                {
                    MessageBox.Show("El campo de Núm. de control debe contener información", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd");
                    string horaAhora = DateTime.Now.ToString("HH:mm:ss");

                    bool resultado = conexion.ejecutarComando($"UPDATE asistencia SET estado = '{comboBox1.Text}', hora = '{horaAhora}' WHERE no_control = '{txtNumControl.Text}' AND fecha = '{fechaHoy}'");

                    if (resultado == true)
                    {
                        MessageBox.Show("Asistencia ACTUALIZADA correctamente");
                        txtNumControl.Clear();
                        comboBox1.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la asistencia (Verifica que el alumno tenga una falta hoy)");
                    }
                }
                DataSet ds = conexion.ejecutar("SELECT * FROM asistencia WHERE fecha = CURDATE()");
                dgvListaAlumnos.DataSource = ds.Tables[0];
            }


            //if (rbAsistencia.Checked)
            //{
            //    if (txtNumControl.Text == "")
            //    {
            //        MessageBox.Show("El campo de Núm. de control debe contener información", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        bool resultado = conexion.ejecutarComando($"UPDATE asistencia SET estado = '{comboBox1.Text}' WHERE no_control = '{txtNumControl.Text}'");
            //        if (resultado == true)
            //        {
            //            MessageBox.Show("Asistencia ACTUALIZADA correctamente");
            //            txtNumControl.Clear();
            //            comboBox1.SelectedIndex = -1;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error al actualizar la asistencia");
            //        }
            //    }
            //    DataSet ds = conexion.ejecutar("Select * from asistencia");
            //    dgvListaAlumnos.DataSource = ds.Tables[0];
            //}
        }

        private void dtpFechaActual_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtNumControl.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string noControl = dgvListaAlumnos.CurrentRow.Cells["no_control"].Value.ToString();

            if (rbAlumno.Checked)
            {
                if (MessageBox.Show("¿Deseas eliminar el alumno con No. control?: " + noControl, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = conexion.ejecutarComando($"DELETE FROM alumnos WHERE no_control = '{noControl}'");

                    if (resultado)
                    {
                        MessageBox.Show("Alumno eliminado correctamente");
                        DataSet ds = conexion.ejecutar("SELECT * FROM alumnos");

                        if (ds != null)
                        {
                            dgvListaAlumnos.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el alumno");
                        }
                    }
                }
            }
            if (rbAsistencia.Checked)
            {
                if (MessageBox.Show("¿Deseas eliminar el alumno con No. control?: " + noControl, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = conexion.ejecutarComando($"DELETE FROM asistencia WHERE no_control = '{noControl}'");

                    if (resultado)
                    {
                        MessageBox.Show("Asistencia eliminada correctamente");
                        DataSet ds = conexion.ejecutar("SELECT * FROM asistencia");

                        if (ds != null)
                        {
                            dgvListaAlumnos.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la asitencia");
                        }
                    }
                }
            }
            //if (MessageBox.Show("¿Desea eliminar el alumno?: " + dgvListaAlumnos.CurrentRow.Cells[1].Value.ToString(),
            //    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    bool resultado = conexion.ejecutarComando($"DELETE FROM alumnos WHERE id = {dgvListaAlumnos.CurrentRow.Cells[1].Value}");
            //    bool resultado2 = conexion.ejecutarComando($"DELETE FROM asistencia WHERE no_control = '{dgvListaAlumnos.CurrentRow.Cells[1].Value}'");
            //    if (resultado == true && resultado2 == true)
            //    {
            //        MessageBox.Show("Alumno eliminado correctamente");
            //        // Refrescar el DataGridView después de eliminar
            //        DataSet ds = conexion.ejecutar("SELECT * FROM alumnos");
            //        if (ds != null)
            //        {
            //            dgvListaAlumnos.DataSource = ds.Tables[0];
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al eliminar el alumno");
            //    }
            //}
        }

        private void dgvListaAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void msEliminar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string fecha = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string consulta = "SELECT * FROM asistencia WHERE fecha = '" + fecha + "'";

                DataSet ds = conexion.ejecutar(consulta);

                if (ds != null && ds.Tables.Count > 0)
                {
                    dgvListaAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rbAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            DateTime tiempo = DateTime.Now;

            if (rbAsistencia.Checked)
            {
                DataSet ds = conexion.ejecutar("SELECT * FROM asistencia");

                if (ds != null)
                {
                    dgvListaAlumnos.DataSource = ds.Tables[0];

                }
                else
                {
                    MessageBox.Show("Error al cargar los datos");
                }
            }
        }

        private void rbAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumno.Checked)
            {
                DataSet ds = conexion.ejecutar("SELECT * FROM alumnos");

                if (ds != null)
                {
                    dgvListaAlumnos.DataSource = ds.Tables[0];

                }
                else
                {
                    MessageBox.Show("Error al cargar los datos");
                }
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarFaltasDelDia();
            rbAsistencia.Checked = true;

            rbAlumno.Checked = true;
            DataSet ds = conexion.ejecutar("SELECT * FROM alumnos");
            if (ds != null)
            {
                dgvListaAlumnos.DataSource = ds.Tables[0];
            }
            txtNumControl.Focus();
        }

        private void txtNumControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void GenerarFaltasDelDia()
        {
            DateTime ahora = DateTime.Now;
            DataSet todosLosAlumnos = conexion.ejecutar("SELECT no_control FROM alumnos");

            if (todosLosAlumnos != null)
            {
                foreach (DataRow fila in todosLosAlumnos.Tables[0].Rows)
                {
                    string nCon = fila["no_control"].ToString();

                    DataSet existeHoy = conexion.ejecutar($"SELECT * FROM asistencia WHERE no_control = '{nCon}' AND fecha = '{ahora.ToString("yyyy-MM-dd")}'");

                    if (existeHoy == null || existeHoy.Tables[0].Rows.Count == 0)
                    {
                        MySqlCommand cmdFalta = new MySqlCommand("INSERT INTO asistencia (no_control, fecha, hora, estado) VALUES (@no, @fec, @hor, @est)");
                        cmdFalta.Parameters.AddWithValue("@no", nCon);
                        cmdFalta.Parameters.AddWithValue("@fec", ahora.Date);
                        cmdFalta.Parameters.AddWithValue("@hor", ahora.TimeOfDay);
                        cmdFalta.Parameters.AddWithValue("@est", "Falta");

                        conexion.ejecutarComando(cmdFalta);
                    }
                }
            }
        }
    }
}