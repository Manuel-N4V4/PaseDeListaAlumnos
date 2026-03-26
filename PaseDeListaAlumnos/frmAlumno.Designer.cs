namespace PaseDeListaAlumnos
{
    partial class frmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtNoControl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            label5 = new Label();
            btnCancelar = new Button();
            cbCarrera = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(13, 71);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            txtNombre.Location = new Point(13, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 30);
            txtNombre.TabIndex = 1;
            // 
            // txtNoControl
            // 
            txtNoControl.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            txtNoControl.Location = new Point(276, 97);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(204, 30);
            txtNoControl.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(276, 71);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 2;
            label2.Text = "Numero de control:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(13, 137);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 4;
            label3.Text = "Carrera:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkSeaGreen;
            btnRegistrar.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(276, 159);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(99, 32);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(122, 9);
            label5.Name = "label5";
            label5.Size = new Size(264, 34);
            label5.TabIndex = 9;
            label5.Text = "Registro del alumno";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(381, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 32);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbCarrera
            // 
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Location = new Point(13, 163);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(247, 28);
            cbCarrera.TabIndex = 11;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(492, 207);
            Controls.Add(cbCarrera);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(txtNoControl);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmAlumno";
            Text = "Registro del alumno";
            Load += frmAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtNoControl;
        private Label label2;
        private Label label3;
        private Button btnRegistrar;
        private Label label5;
        private Button btnCancelar;
        private ComboBox cbCarrera;
    }
}