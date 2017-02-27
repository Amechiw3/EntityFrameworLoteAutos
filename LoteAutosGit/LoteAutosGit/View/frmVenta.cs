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
using LoteAutosGit.View;

namespace LoteAutosGit
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        public int colocar;

        public bool validadDatos()
        {
            return (txtNombre.Text != "" && txtAppaterno.Text != "" && txtApMaterno.Text != "" && txtCurp.Text != "" &&
                    txtCalle.Text != "" && txtNoCasa.Text != "" && txtAvenida.Text != "" && txtCiudad.Text != "" && txtPais.Text != "");
        }
        

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

        private void dgvAutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtSubtotal.Text = this.dgvAutos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtIva.Text = (double.Parse(this.dgvAutos.Rows[e.RowIndex].Cells[5].Value.ToString()) * 0.16).ToString();
                txtTotal.Text = (double.Parse(this.dgvAutos.Rows[e.RowIndex].Cells[5].Value.ToString()) * 1.16).ToString();
                this.dgvGaleria.DataSource = clsAuto.getfoto(int.Parse(this.dgvAutos.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.dgvAutos.AutoGenerateColumns = false;
            this.dgvAutos.DataSource = clsAuto.getAll();
           // this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        int idcliente = 0;
        public void llenarCliente(int idComprador) 
        {

            var llenar = clsComprador.llenarComprador(idComprador);
            idcliente = llenar.idcomprador;
            txtNombre.Text = llenar.nombre;
            txtAppaterno.Text = llenar.appaterno;
            txtApMaterno.Text = llenar.apmaterno;
            txtCurp.Text = llenar.Ine;
            txtCalle.Text = llenar.calle;
            txtColonia.Text = llenar.colonia;
            txtNoCasa.Text = llenar.ncasa;
            txtAvenida.Text = llenar.avenida;
            txtCiudad.Text = llenar.ciudad;
            txtPais.Text = llenar.pais;

        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new FrmListaCompradores(this);
            buscar.ShowDialog();
        }

        private void gbComprador_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscarAutos_TextChanged(object sender, EventArgs e)
        {
            this.dgvAutos.DataSource = clsAuto.getAllSearch(txtBuscarAutos.Text);
        }
    }
}
