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
    public partial class propietario : Form
    {
        Webcam webcam;
        public propietario()
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
            //Webcam.SaveImageCapture(pcbFoto.Image);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarPropietario())
            {
                if (validarAuto())
                {

                }
                else
                {

                }
            }
            else
            {

            }
        }

        public bool validarAuto()
        {
            if (txtNserie.Text != "")
            {
                LoteAutosGit.Models.auto datos = clsManejoAutos.searchNSerie(txtNserie.Text);
                if (datos != null)
                {
                    return (txtMarca.Text != "" && txtModelo.Text != "" && txtPlaca.Text != "" && txtColor.Text != "" && txtNacionalidad.Text != "");
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
                LoteAutosGit.Models.propietario datos = clsManejoPropietarios.searchINE(txtINE.Text);
                if (datos == null)
                {
                    return (txtNombre.Text != "" && txtAppaterno.Text != "" && txtApmaterno.Text != "" && txtCalle.Text != "" && txtNcasa.Text != "" && txtAvenida.Text != "" && txtColonia.Text != "" && txtCiudad.Text != "" && txtPais.Text != "");
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
