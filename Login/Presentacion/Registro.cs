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
    public partial class Registro : Form
    {
        ValidacionCampos VCampos = new ValidacionCampos();
        public Registro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Usuarios oUsuaarios = new Usuarios();
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            oUsuaarios.AgregarUsuarios();
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            VCampos.Letras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            VCampos.Letras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            VCampos.Numeros(e);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            VCampos.LetrasNumeros(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            VCampos.LetrasNumeros(e);
        }
    }
}
