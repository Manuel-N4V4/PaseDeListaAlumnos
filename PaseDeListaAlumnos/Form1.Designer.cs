namespace PaseDeListaAlumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumControl = new TextBox();
            label1 = new Label();
            dgvListaAlumnos = new DataGridView();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            btnRegistrar = new Button();
            btnEditar = new Button();
            btnBuscar = new Button();
            btnRegistrarAlumno = new Button();
            btnAyuda = new Button();
            btnEliminar = new Button();
            msEliminar = new MenuStrip();
            groupBox1 = new GroupBox();
            rbAlumno = new RadioButton();
            rbAsistencia = new RadioButton();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaAlumnos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumControl
            // 
            txtNumControl.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            txtNumControl.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumControl.Location = new Point(12, 51);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(159, 27);
            txtNumControl.TabIndex = 1;
            txtNumControl.TextChanged += textBox1_TextChanged;
            txtNumControl.KeyDown += txtNumControl_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 2;
            label1.Text = "Núm. de control:";
            // 
            // dgvListaAlumnos
            // 
            dgvListaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaAlumnos.GridColor = Color.FromArgb(224, 224, 224);
            dgvListaAlumnos.Location = new Point(351, 51);
            dgvListaAlumnos.Name = "dgvListaAlumnos";
            dgvListaAlumnos.RowHeadersWidth = 51;
            dgvListaAlumnos.Size = new Size(605, 305);
            dgvListaAlumnos.TabIndex = 6;
            dgvListaAlumnos.CellContentClick += dataGridView1_CellContentClick;
            dgvListaAlumnos.CellContentDoubleClick += dgvListaAlumnos_CellContentDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(10, 261);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 7;
            label2.Text = "Buscar fecha:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker2.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker2.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dateTimePicker2.Location = new Point(12, 294);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(294, 27);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(177, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.DarkSeaGreen;
            btnRegistrar.Location = new Point(12, 84);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(294, 29);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Coral;
            btnEditar.Location = new Point(12, 119);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(83, 29);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button2_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.DeepSkyBlue;
            btnBuscar.Location = new Point(118, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 29);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button3_Click;
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.BackColor = Color.DarkSeaGreen;
            btnRegistrarAlumno.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            btnRegistrarAlumno.ForeColor = Color.White;
            btnRegistrarAlumno.Location = new Point(12, 327);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.Size = new Size(294, 29);
            btnRegistrarAlumno.TabIndex = 13;
            btnRegistrarAlumno.Text = "Registrar alumno";
            btnRegistrarAlumno.UseVisualStyleBackColor = false;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.White;
            btnAyuda.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = Color.Gold;
            btnAyuda.Location = new Point(212, 372);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(94, 29);
            btnAyuda.TabIndex = 14;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.IndianRed;
            btnEliminar.Location = new Point(223, 119);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(83, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // msEliminar
            // 
            msEliminar.ImageScalingSize = new Size(20, 20);
            msEliminar.Location = new Point(0, 0);
            msEliminar.Name = "msEliminar";
            msEliminar.Size = new Size(965, 24);
            msEliminar.TabIndex = 16;
            msEliminar.Text = "menuStrip1";
            msEliminar.ItemClicked += msEliminar_ItemClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAlumno);
            groupBox1.Controls.Add(rbAsistencia);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(12, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 89);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿Qué lista desea ver?";
            // 
            // rbAlumno
            // 
            rbAlumno.AutoSize = true;
            rbAlumno.Location = new Point(29, 59);
            rbAlumno.Name = "rbAlumno";
            rbAlumno.Size = new Size(148, 24);
            rbAlumno.TabIndex = 1;
            rbAlumno.TabStop = true;
            rbAlumno.Text = "Lista de alumnos";
            rbAlumno.UseVisualStyleBackColor = true;
            rbAlumno.CheckedChanged += rbAlumno_CheckedChanged;
            // 
            // rbAsistencia
            // 
            rbAsistencia.AutoSize = true;
            rbAsistencia.Location = new Point(29, 29);
            rbAsistencia.Name = "rbAsistencia";
            rbAsistencia.Size = new Size(156, 24);
            rbAsistencia.TabIndex = 0;
            rbAsistencia.TabStop = true;
            rbAsistencia.Text = "Lista de asistencia";
            rbAsistencia.UseVisualStyleBackColor = true;
            rbAsistencia.CheckedChanged += rbAsistencia_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(177, 28);
            label11.Name = "label11";
            label11.Size = new Size(112, 20);
            label11.TabIndex = 38;
            label11.Text = "Participación:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(965, 416);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAyuda);
            Controls.Add(btnRegistrarAlumno);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrar);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dgvListaAlumnos);
            Controls.Add(label1);
            Controls.Add(txtNumControl);
            Controls.Add(msEliminar);
            MainMenuStrip = msEliminar;
            Name = "Form1";
            Text = "Pase de lista";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaAlumnos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox txtNumControl;
        private Label label1;
        private DataGridView dgvListaAlumnos;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnBuscar;
        private Button btnRegistrarAlumno;
        private Button btnAyuda;
        private Button btnEliminar;
        private MenuStrip msEliminar;
        private GroupBox groupBox1;
        private RadioButton rbAlumno;
        private RadioButton rbAsistencia;
        private Label label11;
    }
}
