namespace AppGestionClinica.Forms.Recepcion
{
    partial class FrmCitas
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
            cmbDoctor = new ComboBox();
            label3 = new Label();
            cmbPaciente = new ComboBox();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            cmbHora = new ComboBox();
            btnAsignar = new Button();
            lblVerCita = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 40);
            label1.TabIndex = 0;
            label1.Text = "Asignar Cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 105);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Doctor";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(340, 97);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(217, 23);
            cmbDoctor.TabIndex = 2;
            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 148);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Paciente";
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(340, 140);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(217, 23);
            cmbPaciente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 186);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(340, 180);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(217, 23);
            dtpFecha.TabIndex = 6;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 223);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Hora";
            // 
            // cmbHora
            // 
            cmbHora.FormattingEnabled = true;
            cmbHora.Location = new Point(340, 215);
            cmbHora.Name = "cmbHora";
            cmbHora.Size = new Size(217, 23);
            cmbHora.TabIndex = 8;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(367, 268);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(140, 43);
            btnAsignar.TabIndex = 9;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lblVerCita
            // 
            lblVerCita.AutoSize = true;
            lblVerCita.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblVerCita.ForeColor = Color.IndianRed;
            lblVerCita.Location = new Point(717, 34);
            lblVerCita.Name = "lblVerCita";
            lblVerCita.Size = new Size(71, 21);
            lblVerCita.TabIndex = 10;
            lblVerCita.Text = "Ver citas";
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVerCita);
            Controls.Add(btnAsignar);
            Controls.Add(cmbHora);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(cmbPaciente);
            Controls.Add(label3);
            Controls.Add(cmbDoctor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCitas";
            Text = "FrmCitas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbDoctor;
        private Label label3;
        private ComboBox cmbPaciente;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label5;
        private ComboBox cmbHora;
        private Button btnAsignar;
        private Label lblVerCita;
    }
}