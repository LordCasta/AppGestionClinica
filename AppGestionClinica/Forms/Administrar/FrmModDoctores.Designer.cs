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
            btnCrearDoctor = new Button();
            dgvDoctores = new DataGridView();
            doctorRepositoryBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txt1 = new Label();
            cmbEspecializacion = new ComboBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).BeginInit();
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
            // btnCrearDoctor
            // 
            btnCrearDoctor.Location = new Point(118, 303);
            btnCrearDoctor.Name = "btnCrearDoctor";
            btnCrearDoctor.Size = new Size(107, 31);
            btnCrearDoctor.TabIndex = 8;
            btnCrearDoctor.Text = "Crear";
            btnCrearDoctor.UseVisualStyleBackColor = true;
            btnCrearDoctor.Click += btnCrearDoctor_Click;
            // 
            // dgvDoctores
            // 
            dgvDoctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctores.Location = new Point(476, 99);
            dgvDoctores.Name = "dgvDoctores";
            dgvDoctores.Size = new Size(535, 572);
            dgvDoctores.TabIndex = 9;
            dgvDoctores.CellClick += dgvDoctores_CellClick;
            // 
            // doctorRepositoryBindingSource
            // 
            doctorRepositoryBindingSource.DataSource = typeof(Repository.DoctorRepository);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 115);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 10;
            label2.Text = "CREAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 11;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 157);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 25);
            txtNombre.TabIndex = 12;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Location = new Point(12, 208);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 17);
            txt1.TabIndex = 13;
            txt1.Text = "Especialización";
            // 
            // cmbEspecializacion
            // 
            cmbEspecializacion.FormattingEnabled = true;
            cmbEspecializacion.Location = new Point(118, 200);
            cmbEspecializacion.Name = "cmbEspecializacion";
            cmbEspecializacion.Size = new Size(215, 25);
            cmbEspecializacion.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 253);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 15;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(118, 245);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 25);
            txtTelefono.TabIndex = 16;
            // 
            // FrmModDoctores
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 749);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(cmbEspecializacion);
            Controls.Add(txt1);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDoctores);
            Controls.Add(btnCrearDoctor);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmModDoctores";
            Text = "FrmModDoctores";
            Load += FrmModDoctores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCrearDoctor;
        private DataGridView dgvDoctores;
        private BindingSource doctorRepositoryBindingSource;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label txt1;
        private ComboBox cmbEspecializacion;
        private Label label4;
        private TextBox txtTelefono;
    }
}