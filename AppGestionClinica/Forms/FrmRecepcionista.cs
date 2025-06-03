using AppGestionClinica.Forms.Recepcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionClinica.Forms
{
    public partial class frmRecepcionista : Form
    {
        public frmRecepcionista()
        {
            InitializeComponent();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmCitas().ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmPagos().ShowDialog();
        }
    }
}
