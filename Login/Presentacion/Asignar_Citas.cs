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
    public partial class Asignar_Citas : Form
    {
        public Asignar_Citas()
        {
            InitializeComponent();
        }

        private void Asignar_Citas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal Perfil = new frmPaginaPrincipal();
            Perfil.Show();
            this.Hide();
        }

        Citas Cita = new Citas();
        private void btnPedirCita_Click(object sender, EventArgs e)
        {
            Cita.PedirCita(long.Parse(txtIdPaciente.Text), DateTime.Parse(dtpFechaSolicitud.Text), DateTime.Parse(dtpFechaCita.Text),  TimeSpan.Parse (cbxHoraCita.Text));
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            Cita.CancelarCita(long.Parse(txtIdPaciente.Text));
        }

        private void btnModicarCita_Click(object sender, EventArgs e)
        {
            Cita.ModificarCita(long.Parse(txtIdPaciente.Text), DateTime.Parse(dtpFechaSolicitud.Text), DateTime.Parse(dtpFechaCita.Text), TimeSpan.Parse(cbxHoraCita.Text));
        }

        ValidacionCampos oValidar = new ValidacionCampos();
        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            oValidar.Numeros(e);
        }

        private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            oValidar.Numeros(e);
        }
    }
}
