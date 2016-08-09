using Datos_1.DSLoginTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_1
{
    public class CADRegistro
    {
        public string Nombres;
        public string Apellidos;
        public string Telefono;
        public string Correo;
        public string Usuario;
        public string Contraseña;

        private static DatosTableAdapter Adaptador = new DatosTableAdapter();
        public void AgregarUsuario(string Nombres, string Apellidos , string Telefono, string Correo, string Usuario, string Contraseña)
        {
            Adaptador.spr_InsertarUsuario(Nombres, Apellidos , Telefono, Correo, Usuario, Contraseña);
        }
    }
}
