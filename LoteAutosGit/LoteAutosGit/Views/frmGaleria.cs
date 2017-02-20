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
    public partial class frmGaleria : Form
    {
        Webcam webcam;
        int idauto;
        public frmGaleria(int id)
        {
            InitializeComponent();
            idauto = id;
            webcam = new Webcam();
            webcam.InitializeWebCam(ref pcbFoto);
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            Webcam.SaveImage(pcbFoto);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datos = new galeria();
            webcam.Stop();
            datos.fotografia = Webcam.SaveImageCapture(pcbFoto.Image);
            clsGaleria.saveGaleria(datos, idauto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
