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
    public partial class frmUsuarios : Form
    {
        public void CargarDatos()
        {
            grdDatos.DataSource = ClsManejadorUsers.getAll();
        }

        public frmUsuarios()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
            cmbFiltro.SelectedIndex = 0;
        }

        private void grdDatos_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "Registros: " + grdDatos.Rows.Count;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNewUser newuser = new frmNewUser();
            newuser.Show();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            ClsManejadorUsers.FILTRAR filtro = (ClsManejadorUsers.FILTRAR)cmbFiltro.SelectedIndex;
            grdDatos.DataSource = ClsManejadorUsers.search(filtro, txtValor.Text);
        }
    }
}
