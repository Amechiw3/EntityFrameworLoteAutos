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

namespace LoteAutosGit.Views
{
    public partial class frmGaleria : Form
    {
        Webcam webcam;
        public frmGaleria()
        {
            InitializeComponent();

            webcam = new Webcam();
            webcam.InitializeWebCam(ref pcbFoto);
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }
    }
}
