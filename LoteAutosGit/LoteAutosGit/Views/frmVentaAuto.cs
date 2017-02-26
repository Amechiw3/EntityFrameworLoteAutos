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
    public partial class frmVentaAuto : Form
    {
        int idcomprador;
        public frmVentaAuto(int id)
        {
            InitializeComponent();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.DataSource = clsAuto.getAll();
            idcomprador = id;
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            venta datos = new venta();
            datos.fecha = DateTime.Now;
            int idauto = int.Parse(this.dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString());
            clsventa.Venta(idauto, frmMainSistema.SessionActiva.usuario.idusuario, idcomprador, datos);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = clsAuto.getAllSearch(txtBuscar.Text);
        }
    }
}
