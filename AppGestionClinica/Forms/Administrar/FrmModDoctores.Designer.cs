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
            // btnCrearDoctor
            // 
            btnCrearDoctor.Location = new Point(45, 171);
            btnCrearDoctor.Name = "btnCrearDoctor";
            btnCrearDoctor.Size = new Size(107, 31);
            btnCrearDoctor.TabIndex = 8;
            btnCrearDoctor.Text = "Crear";
            btnCrearDoctor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(216, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(609, 447);
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
            ClientSize = new Size(914, 548);
            Controls.Add(dataGridView1);
            Controls.Add(btnCrearDoctor);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmModDoctores";
            Text = "FrmModDoctores";
            Load += FrmModDoctores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCrearDoctor;
        private DataGridView dataGridView1;
        private BindingSource doctorRepositoryBindingSource;
    }
}