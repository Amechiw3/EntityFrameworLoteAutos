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

namespace LoteAutosGit.View
{
    public partial class FrmListaCompradores : Form
    {
        frmVenta vMain;
        public FrmListaCompradores(frmVenta vPrinc)
        {
            InitializeComponent();
            vMain = vPrinc;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgvListaCompradores.DataSource = clsComprador.searchName(textBox1.Text);
        }

        private void FrmListaCompradores_Load(object sender, EventArgs e)
        {
            this.dgvListaCompradores.AutoGenerateColumns = false;
            this.dgvListaCompradores.DataSource = clsComprador.GetAllComprador();
          

        }

        private void dgvListaCompradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                vMain.colocar = int.Parse(this.dgvListaCompradores.Rows[e.RowIndex].Cells[0].Value.ToString());
                vMain.llenarCliente(int.Parse(this.dgvListaCompradores.Rows[e.RowIndex].Cells[0].Value.ToString()));
                this.Close();
            }
        }
    }
}

