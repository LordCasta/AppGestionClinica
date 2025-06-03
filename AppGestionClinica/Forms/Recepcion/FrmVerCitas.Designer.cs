namespace AppGestionClinica.Forms.Recepcion
{
    partial class FrmVerCitas
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
            cmbDoctores = new ComboBox();
            cmbPacientes = new ComboBox();
            dgvDoctores = new DataGridView();
            dgvPacientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 40);
            label1.TabIndex = 0;
            label1.Text = "Ver Citas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 60);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 1;
            label2.Text = "Doctores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(597, 60);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Pacientes";
            // 
            // cmbDoctores
            // 
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(52, 97);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(191, 23);
            cmbDoctores.TabIndex = 3;
            // 
            // cmbPacientes
            // 
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new Point(553, 97);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(191, 23);
            cmbPacientes.TabIndex = 4;
            // 
            // dgvDoctores
            // 
            dgvDoctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctores.Location = new Point(27, 147);
            dgvDoctores.Name = "dgvDoctores";
            dgvDoctores.Size = new Size(350, 340);
            dgvDoctores.TabIndex = 5;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(461, 147);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(350, 340);
            dgvPacientes.TabIndex = 6;
            // 
            // FrmVerCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 499);
            Controls.Add(dgvPacientes);
            Controls.Add(dgvDoctores);
            Controls.Add(cmbPacientes);
            Controls.Add(cmbDoctores);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVerCitas";
            Text = "FrmVerCitas";
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbDoctores;
        private ComboBox cmbPacientes;
        private DataGridView dgvDoctores;
        private DataGridView dgvPacientes;
    }
}