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
    public partial class Diagnostico : Form
    {
        public Diagnostico()
        {
            InitializeComponent();
        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        ValidacionCampos oValidar = new ValidacionCampos();

        private void txtIdDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            oValidar.Numeros(e);
        }

        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            oValidar.Numeros(e);
        }

        private void rtbDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            oValidar.Letras(e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DiagnosticoPaciente oDiagPaci = new DiagnosticoPaciente();
        private void btnGererarDiagnostico_Click(object sender, EventArgs e)
        {
            oDiagPaci.GenerarDiagnostico(long.Parse(txtIdDiagnostico.Text), long.Parse(txtIdPaciente.Text), rtbDiagnostico.Text);
        }

        private void btnEditarDiagnostico_Click(object sender, EventArgs e)
        {
            //oDiagPaci.EditarDiagnostico(long.Parse(txtIdPaciente.Text), long.Parse(txtIdDiagnostico.Text, rtbDiagnostico.Text));
        }

        private void btnEliminarDiagnostico_Click(object sender, EventArgs e)
        {
            oDiagPaci.EliminarDiagnostico(long.Parse(txtIdDiagnostico.Text));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
