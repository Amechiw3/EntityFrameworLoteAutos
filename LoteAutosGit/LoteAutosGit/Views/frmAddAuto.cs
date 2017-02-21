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
        int idpropietario;
        public frmAddAuto(int id)
        {
            InitializeComponent();
            idpropietario = id;
            webcam = new Webcam();
        }

        private void frmAddAuto_Load(object sender, EventArgs e)
        {

        }
        

        private void btnNvoProp_Click(object sender, EventArgs e)
        {

        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            webcam.InitializeWebCam(ref pcbFoto1);
            webcam.Start();            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(validarfoto())
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

                galeria datosGla1 = new galeria();
                datosGla1.fotografia = Webcam.SaveImageCapture(pcbFoto1.Image);
                clsGaleria.saveGaleria(datosGla1, datos.idauto);

                galeria datosGla2 = new galeria();
                datosGla2.fotografia = Webcam.SaveImageCapture(pcbFoto2.Image);
                clsGaleria.saveGaleria(datosGla2, datos.idauto);

                galeria datosGla3 = new galeria();
                datosGla3.fotografia = Webcam.SaveImageCapture(pcbFoto3.Image);
                clsGaleria.saveGaleria(datosGla3, datos.idauto);
            }
            else
            {
                MessageBox.Show("Faltan las imagenes");
            }
            

        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar1_Click(object sender, EventArgs e)
        {
            Webcam.SaveImage(pcbFoto1);
        }

        private void btnExaminar2_Click(object sender, EventArgs e)
        {
            Webcam.SaveImage(pcbFoto2);
        }

        private void btnExaminar3_Click(object sender, EventArgs e)
        {
            Webcam.SaveImage(pcbFoto3);
        }

        public bool validarfoto()
        {
            return (pcbFoto1.Image != null && pcbFoto2.Image != null && pcbFoto3.Image != null);
        }
    }
}
