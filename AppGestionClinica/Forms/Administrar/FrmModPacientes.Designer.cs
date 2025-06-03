namespace AppGestionClinica.Forms.Administrar
{
    partial class FrmModPacientes
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
            txtNombre = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label5 = new Label();
            dtpNacimiento = new DateTimePicker();
            label6 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            btnCrear = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 40);
            label1.TabIndex = 0;
            label1.Text = "PACIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 117);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 1;
            label2.Text = "Crear Paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 218);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 210);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(176, 23);
            txtApellido.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 262);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 6;
            label5.Text = "Nacimiento";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(96, 256);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(178, 23);
            dtpNacimiento.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 300);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 8;
            label6.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(96, 292);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(176, 23);
            txtDireccion.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 339);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 10;
            label7.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(96, 331);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 23);
            txtTelefono.TabIndex = 11;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(108, 378);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(88, 26);
            btnCrear.TabIndex = 12;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(481, 357);
            dataGridView1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(37, 29);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 14;
            label8.Text = "Atrás";
            // 
            // FrmModPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 519);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(btnCrear);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(dtpNacimiento);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmModPacientes";
            Text = "FrmModPacientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtApellido;
        private Label label5;
        private DateTimePicker dtpNacimiento;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtTelefono;
        private Button btnCrear;
        private DataGridView dataGridView1;
        private Label label8;
    }
}