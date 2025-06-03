namespace AppGestionClinica.Forms.Doctor
{
    partial class FrmTratamientosDoctor
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbPaciente = new ComboBox();
            txtTipo = new TextBox();
            txtDuracion = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            dgvTratamientos = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label8 = new Label();
            txtCosto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(358, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 40);
            label1.TabIndex = 0;
            label1.Text = "Tratamiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Duración";
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(99, 100);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(218, 23);
            cmbPaciente.TabIndex = 4;
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(99, 146);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(218, 23);
            txtTipo.TabIndex = 5;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(99, 192);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(218, 23);
            txtDuracion.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 59);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "Crear";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(99, 341);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 25);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvTratamientos
            // 
            dgvTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTratamientos.Location = new Point(418, 100);
            dgvTratamientos.Name = "dgvTratamientos";
            dgvTratamientos.Size = new Size(582, 354);
            dgvTratamientos.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(697, 77);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(66, 20);
            label6.TabIndex = 10;
            label6.Text = "Historial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 244);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 11;
            label7.Text = "Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(99, 238);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(218, 23);
            dtpFechaInicio.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 298);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 13;
            label8.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(99, 290);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(218, 23);
            txtCosto.TabIndex = 14;
            // 
            // FrmTratamientosDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 484);
            Controls.Add(txtCosto);
            Controls.Add(label8);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvTratamientos);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtDuracion);
            Controls.Add(txtTipo);
            Controls.Add(cmbPaciente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmTratamientosDoctor";
            Text = "FrmTratamientosDoctor";
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbPaciente;
        private TextBox txtTipo;
        private TextBox txtDuracion;
        private Label label5;
        private Button btnGuardar;
        private DataGridView dgvTratamientos;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFechaInicio;
        private Label label8;
        private TextBox txtCosto;
    }
}