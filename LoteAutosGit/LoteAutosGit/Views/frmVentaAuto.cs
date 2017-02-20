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
    public partial class frmVentaAuto : Form
    {
        public frmVentaAuto()
        {
            InitializeComponent();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.DataSource = clsAuto.getAll();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
