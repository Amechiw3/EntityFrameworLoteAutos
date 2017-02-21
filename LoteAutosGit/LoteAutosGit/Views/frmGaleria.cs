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
        }

        private void frmGaleria_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clsAuto.getfoto(idauto);
        }
    }
}
