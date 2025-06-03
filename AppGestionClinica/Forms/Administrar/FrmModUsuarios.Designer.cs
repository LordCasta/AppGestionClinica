namespace AppGestionClinica.Forms.Administrar
{
    partial class FrmModUsuarios
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
            txtUsuario = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            label5 = new Label();
            cmbRol = new ComboBox();
            btnCrear = new Button();
            label6 = new Label();
            cmbDoctor = new ComboBox();
            dgvUsuarios = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 19);
            label1.Name = "label1";
            label1.Size = new Size(160, 47);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 128);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 1;
            label2.Text = "CREAR USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(98, 174);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(211, 23);
            txtUsuario.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 4;
            label4.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(98, 226);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(211, 23);
            txtContraseña.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 280);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 6;
            label5.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(98, 272);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(211, 23);
            cmbRol.TabIndex = 7;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(80, 380);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(132, 26);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 320);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 9;
            label6.Text = "Doctor";
            label6.Click += label6_Click;
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(98, 312);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(211, 23);
            cmbDoctor.TabIndex = 10;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(412, 116);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(813, 588);
            dgvUsuarios.TabIndex = 11;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(36, 27);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 12;
            label7.Text = "Atras";
            label7.Click += label7_Click;
            // 
            // FrmModUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 749);
            Controls.Add(label7);
            Controls.Add(dgvUsuarios);
            Controls.Add(cmbDoctor);
            Controls.Add(label6);
            Controls.Add(btnCrear);
            Controls.Add(cmbRol);
            Controls.Add(label5);
            Controls.Add(txtContraseña);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmModUsuarios";
            Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtContraseña;
        private Label label5;
        private ComboBox cmbRol;
        private Button btnCrear;
        private Label label6;
        private ComboBox cmbDoctor;
        private DataGridView dgvUsuarios;
        private Label label7;
    }
}