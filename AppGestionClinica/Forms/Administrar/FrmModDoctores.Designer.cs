namespace AppGestionClinica.Forms.Administrar
{
    partial class FrmModDoctores
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            cmbEspecializacion = new ComboBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            btnCrearDoctor = new Button();
            dataGridView1 = new DataGridView();
            doctorRepositoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 10);
            label1.Name = "label1";
            label1.Size = new Size(251, 26);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRAR DOCTORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 87);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 1;
            label2.Text = "CREAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 25);
            txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 4;
            label4.Text = "Especializacion";
            // 
            // cmbEspecializacion
            // 
            cmbEspecializacion.FormattingEnabled = true;
            cmbEspecializacion.Location = new Point(126, 191);
            cmbEspecializacion.Name = "cmbEspecializacion";
            cmbEspecializacion.Size = new Size(219, 25);
            cmbEspecializacion.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 254);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(126, 246);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(219, 25);
            txtTelefono.TabIndex = 7;
            // 
            // btnCrearDoctor
            // 
            btnCrearDoctor.Location = new Point(103, 319);
            btnCrearDoctor.Name = "btnCrearDoctor";
            btnCrearDoctor.Size = new Size(107, 31);
            btnCrearDoctor.TabIndex = 8;
            btnCrearDoctor.Text = "Crear";
            btnCrearDoctor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(548, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(328, 270);
            dataGridView1.TabIndex = 9;
            // 
            // doctorRepositoryBindingSource
            // 
            doctorRepositoryBindingSource.DataSource = typeof(Repository.DoctorRepository);
            // 
            // FrmModDoctores
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(dataGridView1);
            Controls.Add(btnCrearDoctor);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(cmbEspecializacion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmModDoctores";
            Text = "FrmModDoctores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cmbEspecializacion;
        private Label label5;
        private TextBox txtTelefono;
        private Button btnCrearDoctor;
        private DataGridView dataGridView1;
        private BindingSource doctorRepositoryBindingSource;
    }
}