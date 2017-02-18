using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutosGit.Controllers;

namespace LoteAutosGit.Views
{
    public partial class frmCatAutos : Form
    {
        public frmCatAutos()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = clsAuto.getAll();
        }

        private void frmCatAutos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.lblRegistros.Text = $"Registros: {this.dataGridView1.RowCount}";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clsAuto.getAllSearch(this.txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addprop = new frmAddAuto();
            addprop.ShowDialog();
        }
    }
}
