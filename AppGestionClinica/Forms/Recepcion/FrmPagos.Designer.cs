namespace AppGestionClinica.Forms.Recepcion
{
    partial class FrmPagos
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
            lblSaldo = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbPaciente = new ComboBox();
            cmbTratamiento = new ComboBox();
            txtMonto = new TextBox();
            txtMetodo = new TextBox();
            btnPagar = new Button();
            dgvPagos = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(419, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(99, 40);
            label1.TabIndex = 0;
            label1.Text = "Pagos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Pagar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Tratamiento";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.ForeColor = Color.IndianRed;
            lblSaldo.Location = new Point(104, 217);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(92, 15);
            lblSaldo.TabIndex = 4;
            lblSaldo.Text = "Saldo pendiente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 217);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 5;
            label6.Text = "Pendiente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 255);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "Monto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 300);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 7;
            label8.Text = "Método";
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(104, 116);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(207, 23);
            cmbPaciente.TabIndex = 8;
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
            // 
            // cmbTratamiento
            // 
            cmbTratamiento.FormattingEnabled = true;
            cmbTratamiento.Location = new Point(104, 160);
            cmbTratamiento.Name = "cmbTratamiento";
            cmbTratamiento.Size = new Size(207, 23);
            cmbTratamiento.TabIndex = 9;
            cmbTratamiento.SelectedIndexChanged += cmbTratamiento_SelectedIndexChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(104, 255);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(207, 23);
            txtMonto.TabIndex = 10;
            // 
            // txtMetodo
            // 
            txtMetodo.Location = new Point(104, 292);
            txtMetodo.Name = "txtMetodo";
            txtMetodo.Size = new Size(207, 23);
            txtMetodo.TabIndex = 11;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(97, 360);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(114, 29);
            btnPagar.TabIndex = 12;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(392, 116);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(456, 386);
            dgvPagos.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(565, 93);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 14;
            label5.Text = "Historial de pagos";
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 514);
            Controls.Add(label5);
            Controls.Add(dgvPagos);
            Controls.Add(btnPagar);
            Controls.Add(txtMetodo);
            Controls.Add(txtMonto);
            Controls.Add(cmbTratamiento);
            Controls.Add(cmbPaciente);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblSaldo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPagos";
            Text = "FrmPagos";
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblSaldo;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbPaciente;
        private ComboBox cmbTratamiento;
        private TextBox txtMonto;
        private TextBox txtMetodo;
        private Button btnPagar;
        private DataGridView dgvPagos;
        private Label label5;
    }
}