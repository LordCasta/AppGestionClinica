namespace AppGestionClinica.Forms
{
    partial class frmRecepcionista
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
            btnCitas = new Button();
            btnPagos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 40);
            label1.TabIndex = 0;
            label1.Text = "Recepción";
            // 
            // btnCitas
            // 
            btnCitas.Location = new Point(105, 171);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(174, 73);
            btnCitas.TabIndex = 1;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(521, 170);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(178, 74);
            btnPagos.TabIndex = 2;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            // 
            // frmRecepcionista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPagos);
            Controls.Add(btnCitas);
            Controls.Add(label1);
            Name = "frmRecepcionista";
            Text = "frmRecepcionista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCitas;
        private Button btnPagos;
    }
}