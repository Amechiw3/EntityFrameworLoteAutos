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
                usuarios.idusuario = idusua;
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
                if(txtContraseña.Text == txtRePassword.Text)
                {
                    ClsManejadorUsers.SaveUsers(usuarios, int.Parse(cboNivel.SelectedValue.ToString()));
                    this.Close();
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtContraseña, "La contraseña debe cohicidir");
                    txtContraseña.Clear();
                    txtRePassword.Clear();
                }                
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(groupBox1, "Faltan datos para continuar");
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

        #region VALIDAR Controles
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtAppaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtApmaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtNoExterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtAvenida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 64 && e.KeyChar !=  46)
            { e.Handled = true; }
        }

        #endregion

        int idusua = 0;
        public void llenarUsuario(int id)
        {
            var user = ClsManejadorUsers.returnUsuario(id);
            idusua = user.idusuario;
            txtNombre.Text = user.nombre;
            txtAppaterno.Text = user.appaterno;
            txtApmaterno.Text = user.apmaterno;
            txtCalle.Text = user.calle;
            txtColonia.Text = user.colonia;
            txtNoExterno.Text = user.ncasa;
            txtAvenida.Text = user.avenida;
            txtCiudad.Text = user.ciudad;
            txtPais.Text = user.pais;
            txtUsuario.Text = user.nickname;
            txtCorreo.Text = user.email;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var frmbuscar = new frmListaUsuarios(this);
            frmbuscar.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idusua = 0;
            txtNombre.Text = "";
            txtAppaterno.Text = "";
            txtApmaterno.Text = "";
            txtCalle.Text = "";
            txtColonia.Text = "";
            txtNoExterno.Text = "";
            txtAvenida.Text = "";
            txtCiudad.Text = "";
            txtPais.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
        }
    }
}
