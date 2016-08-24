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
        string TipoUsuario;

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

        public void ActualizarDatos(string text1, string text2, string text3, string text4, string text5, string text6, object cbxTipoUsuario)
        {
            throw new NotImplementedException();
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

        public string TipoUsuario1
        {
            get
            {
                return TipoUsuario;
            }

            set
            {
                TipoUsuario = value;
            }
        }

        private static DatosTableAdapter Adaptador = new DatosTableAdapter();
        public void AgregarUsuario(string Nombres, string Apellidos, string Telefono, string Correo, string Usuario, string Contraseña, string TipoUsuario)
        {
            Adaptador.spr_AgregarUsuarios(Nombres, Apellidos, Telefono, Correo, Usuario, Contraseña, TipoUsuario);
        }

        public void ActualizarDatos(string Nombres, string Apellidos, string Telefono, string Correo, string Usuario, string Contraseña, string TipoUsuario)
        {
            Adaptador.spr_ActualizarDatos(Nombres, Apellidos, Telefono, Correo, Contraseña, TipoUsuario, Usuario);
        }

        public void EliminarUsuarios(string Usuario)
        {
            Adaptador.spr_EliminarUsuarios(Usuario);
        }
    }
}
