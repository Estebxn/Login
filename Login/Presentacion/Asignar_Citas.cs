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
    }
}
