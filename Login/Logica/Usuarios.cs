using Datos_1.DSLoginTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuarios
    {
        string Nombres;
        string Apellidos;
        long Telefono;
        string Correo;
        string Usuario;
        string Contraseña;

        public string Nombres1
        {
            get
            {
                return Nombres;
            }

            set
            {
                Nombres = value;
            }
        }

        public string Apellidos1
        {
            get
            {
                return Apellidos;
            }

            set
            {
                Apellidos = value;
            }
        }

        public long Telefono1
        {
            get
            {
                return Telefono;
            }

            set
            {
                Telefono = value;
            }
        }

        public string Correo1
        {
            get
            {
                return Correo;
            }

            set
            {
                Correo = value;
            }
        }

        public string Usuario1
        {
            get
            {
                return Usuario;
            }

            set
            {
                Usuario = value;
            }
        }

        public string Contraseña1
        {
            get
            {
                return Contraseña;
            }

            set
            {
                Contraseña = value;
            }
        }
         private static DatosTableAdapter Adaptador = new DatosTableAdapter();
        public void AgregarUsuarios()
        {
            Adaptador.spr_AgregarUsuarios(Nombres, Apellidos, "Telefono", Correo, Usuario, Contraseña);
        }
        public void ActualizarDatos()
        {
            Adaptador.spr_ActualizarDatos(Nombres, Apellidos, "Telefono", Correo, Contraseña, Usuario);
        }
        public void EliminarUsuarios()
        {
            Adaptador.spr_EliminarUsuarios(Usuario);
        }
    }
}
