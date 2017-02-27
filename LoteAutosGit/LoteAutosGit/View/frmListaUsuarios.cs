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
    public partial class frmListaUsuarios : Form
    {
        frmUsuarios main;
        public frmListaUsuarios( frmUsuarios second )
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = ClsManejadorUsers.getAllListar(txtBuscar.Text);
            main = second;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = ClsManejadorUsers.getAllListar(txtBuscar.Text);

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                main.llenarUsuario(int.Parse(this.dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString()));
                this.Close();
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(this.dgvUsuarios, "Seleccione un usuario de la lista");
            }
        }
    }
}
