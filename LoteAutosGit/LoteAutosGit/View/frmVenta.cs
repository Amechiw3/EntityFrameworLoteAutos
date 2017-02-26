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
using LoteAutosGit.Tools;
namespace LoteAutosGit
{
    public partial class frmVenta : Form
    {
        Webcam webcam;
        public frmVenta()
        {
            InitializeComponent();
            webcam = new Webcam();
            webcam.InitializeWebCam(ref pcbFoto);
        }

        public bool validadDatos()
        {
            return (txtNombre.Text != "" && txtAppaterno.Text != "" && txtApMaterno.Text != "" && txtCurp.Text != "" &&
                    txtCalle.Text != "" && txtNoCasa.Text != "" && txtAvenida.Text != "" && txtCiudad.Text != "" && txtPais.Text != "");
        }

        public bool validarImage()
        {
            return (pcbFoto.Image != null);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

        private void dgvAutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvGaleria.DataSource = clsAuto.getfoto(int.Parse(this.dgvAutos.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.dgvAutos.AutoGenerateColumns = false;
            this.dgvAutos.DataSource = clsAuto.getAll();
           // this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
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
