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

namespace LoteAutosGit.Views
{
    public partial class frmPagoAuto : Form
    {
        int idpropietario;
        public frmPagoAuto(int idProp)
        {
            InitializeComponent();
            idpropietario = idProp;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = clsAuto.getAllPago(idpropietario);
        }
    }
}
