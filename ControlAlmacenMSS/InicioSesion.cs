using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAlmacenMSS
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void BunMatTextboxUsuarioLogin_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunMatTextboxContraLogin_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxVerContra_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxVerContra.Checked == false)
                BunMatTextboxContraLogin.isPassword = true;
            else
                BunMatTextboxContraLogin.isPassword = false;
        }

        private void ButtonEntLogin_Click(object sender, EventArgs e)
        {

        }

        private void LabelLimpiar_Click(object sender, EventArgs e)
        {
            BunMatTextboxUsuarioLogin.Text = "";
            BunMatTextboxContraLogin.Text = "";
        }

        private void LabelCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
