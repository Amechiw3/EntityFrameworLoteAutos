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
            clsManejoPropietarios.getall(dgvDatosPropietario);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.dgvDatosPropietario.Rows.Clear();
            dgvDatosPropietario.AllowUserToAddRows = true;

            clsManejoPropietarios.searchPRopietario(dgvDatosPropietario, txtNombre.Text);
        }

        private void btnNuevoPropietario_Click(object sender, EventArgs e)
        {
            var nuevopropietario = new Addpropietario();
            nuevopropietario.ShowDialog();
        }
    }
}
