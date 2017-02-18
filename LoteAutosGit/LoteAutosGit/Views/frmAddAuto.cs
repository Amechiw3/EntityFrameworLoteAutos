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
using LoteAutosGit.Tools;

namespace LoteAutosGit.Views
{
    public partial class frmAddAuto : Form
    {
        Webcam webcam;
        public frmAddAuto()
        {
            InitializeComponent();

            webcam = new Webcam();
            webcam.InitializeWebCam(ref pcbFoto);

            this.cboPropierario.DataSource = clsManejoPropietarios.getallCBO();
            this.cboPropierario.DisplayMember = "nombre";
            this.cboPropierario.ValueMember = "idpropietario";
        }

        private void frmAddAuto_Load(object sender, EventArgs e)
        {

        }
        private int idpropietario = 0;
        private void cboPropierario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                propietario datosprop = clsManejoPropietarios.returnPropietario(int.Parse(cboPropierario.SelectedValue.ToString()));
                idpropietario = datosprop.idpropietario;
                txtNombre.Text = datosprop.nombre;
                txtApPaterno.Text = datosprop.appaterno;
                txtApMateno.Text = datosprop.apmaterno;
                txtINE.Text = datosprop.ine;
                txtTelefono.Text = datosprop.telefono;
                txtCorreo.Text = datosprop.correo;
                txtCalle.Text = datosprop.calle;
                txtNoCasa.Text = datosprop.ncasa;
                txtAvenida.Text = datosprop.avenida;
                txtColonia.Text = datosprop.colonia;
                txtCiudad.Text = datosprop.ciudad;
                txtPais.Text = datosprop.pais;
            }
            catch (Exception)
            {
                
            }

        }

        private void btnNvoProp_Click(object sender, EventArgs e)
        {
            idpropietario = 0;
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMateno.Text = "";
            txtINE.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCalle.Text = "";
            txtNoCasa.Text = "";
            txtAvenida.Text = "";
            txtColonia.Clear();
            txtCiudad.Clear();
            txtPais.Clear();          
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            webcam.Start();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idpropietario > 0) //Agregar nuevo Auto
            {
                auto datos = new auto();
                datos.marca = txtMarca.Text;
                datos.modelo = txtModelo.Text;
                datos.color = txtColor.Text;
                datos.precio = double.Parse(txtPrecio.Text);
                datos.nserie = txtNoSerie.Text;
                datos.nacionalidad = txtNacionalidad.Text;
                datos.Observacion = txtObservaciones.Text;
                clsManejoAutos.savenewauto(datos, idpropietario);

            }
            else //Agregar nuevo propietario
            {
                var prop = new propietario();
                prop.nombre = txtNombre.Text;
                prop.appaterno = txtApPaterno.Text;
                prop.apmaterno = txtApMateno.Text;
                prop.ine = txtINE.Text;
                prop.telefono = txtTelefono.Text;
                prop.correo = txtCorreo.Text;
                prop.calle = txtCalle.Text;
                prop.ncasa = txtNoCasa.Text;
                prop.avenida = txtAvenida.Text;
                prop.colonia = txtColonia.Text;
                prop.ciudad = txtCiudad.Text;
                prop.pais = txtPais.Text;
                prop.fotografia = Webcam.SaveImageCapture(pcbFoto.Image);

                auto datos = new auto();
                datos.marca = txtMarca.Text;
                datos.modelo = txtModelo.Text;
                datos.color = txtColor.Text;
                datos.precio = double.Parse(txtPrecio.Text);
                datos.nserie = txtNoSerie.Text;
                datos.nacionalidad = txtNacionalidad.Text;
                datos.Observacion = txtObservaciones.Text;
                clsManejoAutos.savenewauto(datos, idpropietario);
            }
        }
    }
}
