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
using LoteAutosGit.Views;


namespace LoteAutosGit.View
{
    public partial class frmPago : Form
    {
        comprador datosComprador;
        frmVenta ventana;
        int idautos;
        public frmPago(comprador datos, int idauto, double total, frmVenta sec)
        {
            InitializeComponent();
            datosComprador = datos;
            idautos = idauto;
            txtTotal.Text = total.ToString();
            ventana = sec;
        }

        private void frmPago_Load(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int pago = int.Parse(txtPago.Text);
            int total = int.Parse(txtTotal.Text);
            if (pago >= total)
            {
                clsComprador.SaveComprador(datosComprador);
                //var datos = clsAuto.returnauto(idautos);
                //datos.estado = false;
                clsAuto.SaveAuto(idautos);
                venta vta = new venta();
                vta.fecha = DateTime.Now;
                clsventa.Venta(idautos, frmMainSistema.SessionActiva.usuario.idusuario, datosComprador.idcomprador, vta);
                MessageBox.Show("Venta realizada con exito");
                ventana.llenarautos();
                this.Close();
            }
            else
            {
                MessageBox.Show("El pago no cubre el total de la compra");
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            int pago = int.Parse(txtPago.Text);
            int total = int.Parse(txtTotal.Text);
            txtCambio.Text = (total - pago).ToString();
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)  && e.KeyChar != 8)
            { e.Handled = true; }
        }
    }
}
