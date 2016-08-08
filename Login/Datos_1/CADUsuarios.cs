using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_1.DSLoginTableAdapters;

namespace Datos_1
{
    public class CADUsuarios
    {
        private static DatosTableAdapter Adaptador = new DatosTableAdapter;

        public static bool AgregarUsuarios(string Usuario, string Contraseña)
        {
            if(Adaptador.spr_AgregarUsuarios(Nombres, Apellidos, Telefono, Correo, Usuario, Contraseña))
        }
    }
}
