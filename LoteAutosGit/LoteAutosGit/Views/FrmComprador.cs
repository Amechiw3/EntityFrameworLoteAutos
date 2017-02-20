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

namespace LoteAutosGit.Views
{
    public partial class FrmComprador : Form
    {
        public FrmComprador()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var comprador = new comprador();
            comprador.nombre = txtNombre.Text;
            comprador.appaterno = txtAppaterno.Text;
            comprador.apmaterno = txtApMaterno.Text;
            comprador.Ine = txtINE.Text;
            comprador.calle = txtCalle.Text;
            comprador.ncasa = txtNoCasa.Text;
            comprador.avenida = txtAvenida.Text;
            comprador.colonia = txtColonia.Text;
            comprador.ciudad = txtCiudad.Text;
            comprador.pais = txtPais.Text;
            clsComprador.SaveComprador(comprador);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
