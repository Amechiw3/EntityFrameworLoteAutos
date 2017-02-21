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
using System.IO;

namespace LoteAutosGit.Views
{
    public partial class buscarPropietario : Form
    {
        public buscarPropietario()
        {
            InitializeComponent();
            this.dgvDatosPropietario.AutoGenerateColumns = false;
        }

        private void buscarPropietario_Load(object sender, EventArgs e)
        {
            cargarPropietarios();
        }

        public void cargarPropietarios()
        {
            this.dgvDatosPropietario.DataSource = clsManejoPropietarios.getallimage(txtNombre.Text);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.dgvDatosPropietario.DataSource = clsManejoPropietarios.getallimage(txtNombre.Text);

        }

        private void btnNuevoPropietario_Click(object sender, EventArgs e)
        {
            var nuevopropietario = new Addpropietario();
            nuevopropietario.ShowDialog();
        }

        private void dgvDatosPropietario_DataSourceChanged(object sender, EventArgs e)
        {
            this.lblRegistro.Text = $"Registros: {this.dgvDatosPropietario.RowCount}";
        }

        private void dgvDatosPropietario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(this.dgvDatosPropietario.Rows[e.RowIndex].Cells[0].Value.ToString());
            var auto = new frmAddAuto(id);
            auto.ShowDialog();
        }
    }
}
