using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        Usuarios oUsuaarios = new Usuarios();
        Encriptacion Encriptar = new Encriptacion();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            oUsuaarios.AgregarUsuario(txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCorreo.Text, txtUser.Text, txtPassword.Text, cbxTipoUsuario.Text);
            //Encriptar.Encriptar(txtUser.Text, Encriptacion.GetMD5(txtPassword.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login oLogin = new Login();
            oLogin.Show();
            this.Hide();
        }

        ValidacionCampos Validar = new ValidacionCampos();
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Letras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Letras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Numeros(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasNumeros(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasNumeros(e);
        }

        private void cbxTipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Letras(e);
        }
    }
}
