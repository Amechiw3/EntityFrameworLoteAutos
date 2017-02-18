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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClsManejoSession.SessionHelper objSession = ClsManejoSession.Login(txt_nickname.Text, txt_pass.Text);
            if (!objSession.isValid)
            {
                MessageBox.Show("Error:" + objSession.msgError);
            }
            else
            {
                
            }
        }
    }
}
