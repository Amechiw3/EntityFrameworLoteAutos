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
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var galeria = new frmGaleria(int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            galeria.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {

            }
        }
    }
}
