using Datos_1.DSLoginTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_1
{
    public class CADUsuarios
    {
        private static DatosTableAdapter adaptador = new DatosTableAdapter();
        public static bool ValidarUsuario(string Usuario, string Contraseña)
        {


            if (adaptador.spr_Login(Usuario, Contraseña) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
