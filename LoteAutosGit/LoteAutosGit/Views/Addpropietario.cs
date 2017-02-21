using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutosGit.Tools;
using LoteAutosGit.Controllers;
using LoteAutosGit.Models;

namespace LoteAutosGit.Views
{
    public partial class Addpropietario : Form
    {
        Webcam webcam;
        public Addpropietario()
        {
            InitializeComponent();
            webcam = new Webcam();
            webcam.InitializeWebCam(ref pcbFoto);
            cboNacionalidad.SelectedIndex = 1;
        }        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarPropietario())
            {
                if (validarAuto())
                {
                    var datos = new propietario();
                    datos.nombre = txtNombre.Text;
                    datos.appaterno = txtApPaterno.Text;
                    datos.apmaterno = txtApMateno.Text;
                    datos.ine = txtINE.Text;
                    datos.telefono = txtTelefono.Text;
                    datos.correo = txtCorreo.Text;
                    datos.calle = txtCalle.Text;
                    datos.ncasa = txtNoCasa.Text;
                    datos.avenida = txtAvenida.Text;
                    datos.colonia = txtColonia.Text;
                    datos.ciudad = txtCiudad.Text;
                    datos.pais = txtPais.Text;
                    datos.fotografia = Webcam.SaveImageCapture(pcbFoto.Image);
                    //clsManejoPropietarios.SavePropietario(datos);

                    //DataModel ctx = new DataModel();
                    //ctx.propietarios.Attach(datos);

                    var auto = new auto();
                    auto.marca = txtMarca.Text;
                    auto.modelo = txtModelo.Text;
                    auto.nserie = txtNoSerie.Text;
                    auto.precio = double.Parse(txtPrecio.Text);
                    auto.color = txtColor.Text;
                    auto.nacionalidad = cboNacionalidad.Text;
                    auto.Observacion = txtObservaciones.Text;
                    auto.propietarios = datos;
                    clsManejoAutos.SaveAuto(auto);
                }
                else
                {
                    errorINE.Clear();
                    errorINE.SetError(txtNoSerie, "Numero de serie duplicado");
                }
            }
            else
            {
                errorINE.Clear();
                errorINE.SetError(txtINE, "Codigo de INE duplicado");
            }
        }

        public bool validarAuto()
        {
            if (txtNoSerie.Text != "")
            {
                LoteAutosGit.Models.auto datos = clsManejoAutos.searchNSerie(txtNoSerie.Text);
                if (datos == null)
                {
                    return (txtMarca.Text != "" && txtModelo.Text != "" && txtPrecio.Text != "" && txtColor.Text != "");
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool validarPropietario()
        {
            if (txtINE.Text != "")
            {
                propietario datos = clsManejoPropietarios.searchINE(txtINE.Text);
                if (datos == null)
                {
                    return (txtNombre.Text != "" && txtApPaterno.Text != "" && txtApMateno.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "" && txtCalle.Text != "" && txtNoCasa.Text != "" && txtAvenida.Text != "" && txtColonia.Text != "" && txtCiudad.Text != "" && txtPais.Text != "");
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Addpropietario_Load(object sender, EventArgs e)
        {

        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            if (!webcam.camara)
            {
                webcam.Start();
            }
            else
            {
                webcam.Stop();
            }
        }
    }
}
