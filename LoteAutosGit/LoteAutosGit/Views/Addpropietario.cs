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
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            Webcam.SaveImage(pcbFoto);
        }
        
        private void btnTomar_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            //MessageBox.Show(Webcam.SaveImageCapture(pcbFoto.Image));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarPropietario())
            {
                if (validarAuto())
                {
                    var datos = new propietario();
                    datos.nombre = txtNombre.Text;
                    datos.appaterno = txtAppaterno.Text;
                    datos.apmaterno = txtApmaterno.Text;
                    datos.ine = txtINE.Text;
                    datos.telefono = txtTelefono.Text;
                    datos.correo = txtCorreo.Text;
                    datos.calle = txtCalle.Text;
                    datos.ncasa = txtNcasa.Text;
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
                    auto.nserie = txtNserie.Text;
                    auto.precio = double.Parse(txtPrecio.Text);
                    auto.color = txtColor.Text;
                    auto.nacionalidad = txtNacionalidad.Text;
                    auto.Observacion = txtObservaciones.Text;
                    auto.propietarios = datos;
                    clsManejoAutos.SaveAuto(auto);
                }
                else
                {
                    errorINE.Clear();
                    errorINE.SetError(txtNserie, "Numero de serie duplicado");
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
            if (txtNserie.Text != "")
            {
                LoteAutosGit.Models.auto datos = clsManejoAutos.searchNSerie(txtNserie.Text);
                if (datos == null)
                {
                    return (txtMarca.Text != "" && txtModelo.Text != "" && txtPrecio.Text != "" && txtColor.Text != "" && txtNacionalidad.Text != "");
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
                    return (txtNombre.Text != "" && txtAppaterno.Text != "" && txtApmaterno.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "" && txtCalle.Text != "" && txtNcasa.Text != "" && txtAvenida.Text != "" && txtColonia.Text != "" && txtCiudad.Text != "" && txtPais.Text != "");
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
    }
}
