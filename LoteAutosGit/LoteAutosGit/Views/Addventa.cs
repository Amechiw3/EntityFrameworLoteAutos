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
    public partial class AddVenta : Form
    {

        public AddVenta()
        {
            InitializeComponent();
            this.cboAuto.DataSource = clsAuto.getAll();
            this.cboAuto.DisplayMember = "marca";
            this.cboAuto.ValueMember = "idauto";

            this.cboUsuario.DataSource = ClsManejadorUsers.getallCBO();
            this.cboUsuario.DisplayMember = "nombre";
            this.cboUsuario.ValueMember = "idusuario";

            this.cboComprador.DataSource = clsComprador.GetAllComprador();
            this.cboComprador.DisplayMember = "nombre";
            this.cboComprador.ValueMember = "idcomprador";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venta datos = new venta();
            datos.fecha = dateTimePicker1.Value;

            int idcomprador = int.Parse(cboComprador.SelectedValue.ToString());
            int idauto = int.Parse(cboAuto.SelectedValue.ToString());
            int idusuario = int.Parse(cboUsuario.SelectedValue.ToString());
            clsventa.Venta(idauto, idusuario, idcomprador, datos);
            this.Close();
        }
    }
}
