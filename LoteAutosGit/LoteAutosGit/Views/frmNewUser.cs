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
    public partial class frmNewUser : Form
    {
        frmUsuarios wMain;

        public frmNewUser(frmUsuarios wmain)
        {
            InitializeComponent();
            wMain = wmain;
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            var datos = new usuario();
            datos.nombre = txt_name.Text;
            datos.appaterno = txt_app.Text;
            datos.apmaterno = txt_apm.Text;
            datos.calle = txt_calle.Text;
            datos.colonia = txt_col.Text;
            datos.ncasa = txt_numC.Text;
            datos.avenida = txt_avenue.Text;
            datos.ciudad = txtx_ciudad.Text;
            datos.pais = txt_pais.Text;
            datos.email = txt_email.Text;
            datos.nickname = txt_nick.Text;
            datos.password = txt_Pass.Text;
            ClsManejadorUsers.SaveUsers(datos);

            wMain.CargarDatos();
            this.Close();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir?","Aviso!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
