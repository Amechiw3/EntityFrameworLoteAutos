using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutosGit.Models;
using LoteAutosGit.Controllers;

namespace LoteAutosGit.Views
{
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = clsManejoPropietarios.getallCBO();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clsManejoPropietarios.Search(this.txtBuscar.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pagoauto = new frmPagoAuto(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            pagoauto.ShowDialog();
        }
    }
}
