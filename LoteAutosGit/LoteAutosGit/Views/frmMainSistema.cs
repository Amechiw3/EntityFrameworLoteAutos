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
    public partial class frmMainSistema : Form
    {
        public static ClsManejoSession.SessionHelper SessionActiva;

        public frmMainSistema()
        {
            InitializeComponent();
        }
    }
}
