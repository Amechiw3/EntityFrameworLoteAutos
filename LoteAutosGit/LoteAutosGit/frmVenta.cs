using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteAutosGit
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        public bool validadDatos()
        {
            return (txtNombre.Text != "" && txtAppaterno.Text != "" && txtApMaterno.Text != "" && txtCurp.Text != "" &&
                    txtCalle.Text != "" && txtNoCasa.Text != "" && txtAvenida.Text != "" && txtCiudad.Text != "" && txtPais.Text != "");
        }

        public bool validarImage()
        {
            return (pictureBox1.Image != null);
        }
    }
}
