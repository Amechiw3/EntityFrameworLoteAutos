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
    }
}
