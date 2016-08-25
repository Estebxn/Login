using Datos_1;
using Datos_1.DSLoginTableAdapters;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        frmRegistro oRegistro = new frmRegistro();
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            oRegistro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DatosTableAdapter Adaptador = new DatosTableAdapter();
            if (txtUser.Text == "")
            {
                errorProvider1.SetError(txtUser, "Debe ingresar un Usuario");
                txtUser.Focus();
                return;
            }
            errorProvider1.SetError(txtUser, "");

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Debe ingresar una Clave");
                txtPassword.Focus();
                return;
            }
            errorProvider1.SetError(txtPassword, "");

            if (!CADUsuarios.ValidarUsuario(txtUser.Text, txtPassword.Text))
            {

                MessageBox.Show("usuario o clave no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
                return;
            }
            else
            {
                if (Adaptador.spr_Login(txtUser.Text, txtPassword.Text).ToString() == "Paciente")
                {
                    Asignar_Citas PedirCita = new Asignar_Citas();
                    PedirCita.Show();
                    this.Hide();
                }
                else
                {
                    if(Adaptador.spr_Login(txtUser.Text, txtPassword.Text).ToString() == "Doctor")
                    {
                        Diagnostico Diagnostico = new Diagnostico();
                        Diagnostico.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
