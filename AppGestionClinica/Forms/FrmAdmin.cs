﻿using AppGestionClinica.Forms.Administrar;
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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmModDoctores().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmModUsuarios().ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmModPacientes().ShowDialog();
        }
    }
}
