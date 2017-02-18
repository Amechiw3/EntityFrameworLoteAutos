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
    public partial class catAuto : Form
    {
        public catAuto()
        {
            InitializeComponent();
            this.dgvAutos.AutoGenerateColumns = false;
        }

        private void catAuto_Load(object sender, EventArgs e)
        {
            this.dgvAutos.DataSource = clsAuto.getall();
        }
    }
}
