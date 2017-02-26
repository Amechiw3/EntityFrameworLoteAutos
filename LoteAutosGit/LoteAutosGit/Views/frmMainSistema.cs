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
    public partial class frmMainSistema : Form
    {
        public static ClsManejoSession.SessionHelper SessionActiva;

        public frmMainSistema()
        {
            InitializeComponent();
            SessionActiva = new ClsManejoSession.SessionHelper();
        }

        private void compradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var comprador = new FrmComprador();
            comprador.ShowDialog();
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogo = new frmCatAutos();
            catalogo.ShowDialog();
        }

        private void propietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var propietario = new buscarPropietario();
            propietario.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var venta = new AddVenta();
            venta.ShowDialog();*/
            var venta = new frmVenta();
            venta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainSistema_Load(object sender, EventArgs e)
        {
            if (!frmMainSistema.SessionActiva.isValid)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                if (!frmMainSistema.SessionActiva.isValid)
                {
                    this.Close();
                }
            }
        }

        private void TSMIUsuarios_Click(object sender, EventArgs e)
        {
            var usuario = new View.frmUsuarios();
            usuario.ShowDialog();
        }

        private void TSMIpermisos_Click(object sender, EventArgs e)
        {
            var niveles = new View.frmNiveles();
            niveles.ShowDialog();
        }
    }
}
