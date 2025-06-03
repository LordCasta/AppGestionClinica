using AppGestionClinica.Forms.Doctor;
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
    public partial class FrmDoctor : Form
    {
        public FrmDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            new FrmTratamientosDoctor().ShowDialog();
        }
    }
}
