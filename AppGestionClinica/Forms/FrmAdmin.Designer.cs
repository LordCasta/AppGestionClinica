namespace AppGestionClinica.Forms
{
    partial class FrmAdmin
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
            btnDoctores = new Button();
            btnPacientes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 26);
            label1.TabIndex = 0;
            label1.Text = "VISTA ADMIN";
            // 
            // btnDoctores
            // 
            btnDoctores.Location = new Point(99, 92);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(135, 71);
            btnDoctores.TabIndex = 1;
            btnDoctores.Text = "Doctores";
            btnDoctores.UseVisualStyleBackColor = true;
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(339, 94);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(141, 69);
            btnPacientes.TabIndex = 2;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPacientes);
            Controls.Add(btnDoctores);
            Controls.Add(label1);
            Name = "FrmAdmin";
            Text = "FrmAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDoctores;
        private Button btnPacientes;
    }
}