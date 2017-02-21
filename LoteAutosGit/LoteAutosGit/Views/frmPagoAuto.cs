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
using LoteAutosGit.Models;

namespace LoteAutosGit.Views
{
    public partial class frmPagoAuto : Form
    {
        int idpropietario;
        public frmPagoAuto(int idProp)
        {
            InitializeComponent();
            idpropietario = idProp;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = clsAuto.getAllPagoA(idpropietario);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pago pag = clsAuto.searchPago(int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            if (pag != null)
            {
                MessageBox.Show("El auto ya esta pago");
            }
            else
            {
                clsPago.savePago(int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource =
            clsAuto.SearchPagoA(idpropietario, this.textBox1.Text);
        }
    }
}
