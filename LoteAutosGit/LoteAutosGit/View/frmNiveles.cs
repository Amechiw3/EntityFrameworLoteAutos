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

namespace LoteAutosGit.View
{
    public partial class frmNiveles : Form
    {
        public frmNiveles()
        {
            InitializeComponent();
        }

        private void frmNiveles_Load(object sender, EventArgs e)
        {
            cargarNiveles();
        }

        public void cargarNiveles()
        {
            this.cboPermisos.DataSource = clsManejoNivel.getPermisosAll();
            this.cboPermisos.ValueMember = "idpermiso";
            this.cboPermisos.DisplayMember = "modulo";

            this.dgvNiveles.DataSource = clsManejoNivel.getNivelAll();
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            int permiso = int.Parse(cboPermisos.SelectedValue.ToString());
            if(idniveles > 0)
            {
                var permisosnegados = new permisonegado();
                clsPermisosnegados.savePermisos(permisosnegados, idniveles, permiso);
                this.Close();
            }
        }

        int idniveles = 0;
        private void dgvNiveles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idniveles = int.Parse(this.dgvNiveles.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.dgvPermisoNegados.DataSource = clsPermisosnegados.GetAllPermisosNegados(idniveles);

            nivel datos = clsManejoNivel.getNivel(idniveles);
            textBox1.Text = datos.nombre;
            textBox2.Text = datos.descripcion;
            idniveles = datos.idnivel;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                var datos = new nivel();
                datos.idnivel = idniveles;
                datos.nombre = textBox1.Text;
                datos.descripcion = textBox2.Text;
                clsManejoNivel.saveNivel(datos);
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Faltan Datos para continuar");
            }
        }

        private void btnNuevoNivel_Click(object sender, EventArgs e)
        {
            idniveles = 0;
            textBox1.Text = "";
            textBox2.Clear();
        }
    }
}
