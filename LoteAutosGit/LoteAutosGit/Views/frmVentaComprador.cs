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
    public partial class frmVentaComprador : Form
    {
        public frmVentaComprador()
        {
            InitializeComponent();
            this.dgvDatosPropietario.AutoGenerateColumns = false;
            cargarPropietarios();
        }

        public void cargarPropietarios()
        {
            this.dgvDatosPropietario.DataSource = clsManejoPropietarios.getallimage(txtNombre.Text);
        }

        int idcomprador = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.dgvDatosPropietario.DataSource = clsManejoPropietarios.getallimage(txtNombre.Text);
        }

        private void dgvDatosPropietario_DataSourceChanged(object sender, EventArgs e)
        {
            this.lblRegistro.Text = $"Registros: {this.dgvDatosPropietario.RowCount}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.dgvDatosPropietario.SelectedRows.Count > 0)
            {
                /*int id = int.Parse(this.dgvDatosPropietario.Rows[e.RowIndex].Cells[0].Value.ToString());
                var autos = new frmVentaAuto(id);
                autos.ShowDialog();*/
            }
            else { MessageBox.Show("No selecciono nada"); }
        }

        private void dgvDatosPropietario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(this.dgvDatosPropietario.Rows[e.RowIndex].Cells[0].Value.ToString());
            var autos = new frmVentaAuto(id);
            autos.ShowDialog();
        }
    }
}
