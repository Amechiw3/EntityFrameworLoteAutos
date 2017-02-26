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
using LoteAutosGit.Views;

namespace LoteAutosGit.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarNiveles();
            procesarPermisos();

        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            if (validarcampos())
            {
                var usuarios = new usuario();
                usuarios.nombre = txtNombre.Text.Trim();
                usuarios.appaterno = txtAppaterno.Text.Trim();
                usuarios.apmaterno = txtApmaterno.Text.Trim();
                usuarios.calle = txtCalle.Text.Trim();
                usuarios.ncasa = txtNoExterno.Text.Trim();
                usuarios.avenida = txtAvenida.Text.Trim();
                usuarios.colonia = txtColonia.Text.Trim();
                usuarios.ciudad = txtCiudad.Text.Trim();
                usuarios.pais = txtPais.Text.Trim();
                /**/
                usuarios.nickname = txtUsuario.Text.Trim();
                usuarios.password = txtContraseña.Text.Trim();
                usuarios.email = txtCorreo.Text.Trim();
                //usuarios.niveles = clsManejoNivel.getNivel(int.Parse(cboNivel.SelectedValue.ToString()));
                ClsManejadorUsers.SaveUsers(usuarios, int.Parse(cboNivel.SelectedValue.ToString()));
                this.Close();
            }
        }

        public bool validarcampos()
        {
            return (txtNombre.Text != "" && txtAppaterno.Text != "" && txtApmaterno.Text != "" && txtCalle.Text != "" &&
                    txtNoExterno.Text != "" && txtAvenida.Text != "" && txtCiudad.Text != "" && txtPais.Text != "" &&
                    txtUsuario.Text != "" && txtContraseña.Text != "" && txtCorreo.Text != "");
        }

        public void cargarNiveles()
        {
            this.cboNivel.DataSource = clsManejoNivel.getNivelAll();
            this.cboNivel.ValueMember = "idnivel";
            this.cboNivel.DisplayMember = "nombre";
        }

        public void procesarPermisos()
        {
            int permiso = 0;
            foreach (object obj in this.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permiso = Convert.ToInt32(btn.Tag);
                    var SessionActiva = frmMainSistema.SessionActiva;
                    btn.Enabled = SessionActiva.TienePermisos(permiso);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
