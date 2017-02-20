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
            cargarComprador();
        }

        public void cargarComprador()
        {
            cboComprador.DataSource = clsComprador.GetAllComprador();
            cboComprador.DisplayMember = "nombre";
            cboComprador.ValueMember = "idcomprador";
        }

        int idcomprador = 0;

        private void cboComprador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comprador cmp = clsComprador.searchComprador(int.Parse(cboComprador.SelectedValue.ToString()));
                idcomprador = cmp.idcomprador;
                txtNombre.Text = cmp.nombre;
                txtApPaterno.Text = cmp.appaterno;
                txtApMateno.Text = cmp.apmaterno;
                txtINE.Text = cmp.Ine;
                txtCalle.Text = cmp.calle;
                txtNoCasa.Text = cmp.ncasa;
                txtAvenida.Text = cmp.avenida;
                txtColonia.Text = cmp.colonia;
                txtCiudad.Text = cmp.ciudad;
                txtPais.Text = cmp.pais;
            }
            catch (Exception)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(idcomprador > 0) //Comprador en la lista
            {
                var comprador = new comprador();
                comprador.nombre = txtNombre.Text;
                comprador.appaterno = txtApPaterno.Text;
                comprador.apmaterno = txtApMateno.Text;
                comprador.Ine = txtINE.Text;
                comprador.calle = txtCalle.Text;
                comprador.ncasa = txtNoCasa.Text;
                comprador.avenida = txtAvenida.Text;
                comprador.colonia = txtColonia.Text;
                comprador.ciudad = txtCiudad.Text;
                comprador.pais = txtPais.Text;
                comprador.idcomprador = idcomprador;
                clsComprador.SaveComprador(comprador);

                venta vtn = new venta();
                vtn.fecha = DateTime.Now;
            }
            else // Nuevo Comprador
            {
                var comprador = new comprador();
                comprador.nombre = txtNombre.Text;
                comprador.appaterno = txtApPaterno.Text;
                comprador.apmaterno = txtApMateno.Text;
                comprador.Ine = txtINE.Text;
                comprador.calle = txtCalle.Text;
                comprador.ncasa = txtNoCasa.Text;
                comprador.avenida = txtAvenida.Text;
                comprador.colonia = txtColonia.Text;
                comprador.ciudad = txtCiudad.Text;
                comprador.pais = txtPais.Text;
                clsComprador.SaveComprador(comprador);
            }
        }

        private void btnNvoComp_Click(object sender, EventArgs e)
        {
            idcomprador = 0;
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMateno.Text = "";
            txtINE.Text = "";

            txtCalle.Text = "";
            txtNoCasa.Text = "";
            txtAvenida.Text = "";
            txtColonia.Text = "";
            txtCiudad.Text = "";
            txtPais.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
