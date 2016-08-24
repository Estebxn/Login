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
    public partial class frmPaginaPrincipal : Form
    {
        public frmPaginaPrincipal()
        {
            InitializeComponent();
        }

        Usuarios oUsuarios = new Usuarios();
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            oUsuarios.ActualizarDatos(txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCorreo.Text, txtUser.Text, txtPassword.Text, cbxTipoUsuario.Text);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oUsuarios.EliminarUsuarios(txtUser.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ValidacionCampos Validacion = new ValidacionCampos();
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.LetrasNumeros(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.LetrasNumeros(e);
        }
    }
}
