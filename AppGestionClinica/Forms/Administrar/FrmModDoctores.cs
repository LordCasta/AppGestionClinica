using AppGestionClinica.Entities;
using AppGestionClinica.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionClinica.Forms.Administrar
{
    public partial class FrmModDoctores : Form
    {
        DoctorRepository repo = new DoctorRepository();
        BindingList<Doctor> listaDoctores;
        public FrmModDoctores()
        {
            InitializeComponent();
        }

        private void FrmModDoctores_Load(object sender, EventArgs e)
        {
            listaDoctores = new BindingList<Doctor>(repo.ObtenerTodos());
            dataGridView1.DataSource = listaDoctores;

            // Opcional: ocultar la columna ID si no quieres editarla
            dataGridView1.Columns["DoctorID"].ReadOnly = true;
        }
    }
}
