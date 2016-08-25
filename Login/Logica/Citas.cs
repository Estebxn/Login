using Datos_1.DSLoginTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Citas
    {
        long IdPaciente;
        long IdEmpleado;
        DateTime FechaSolicitud;
        DateTime FechaCita;
        TimeSpan HoraCita;


        private static AsignarCitaTableAdapter Adaptador = new AsignarCitaTableAdapter();
        public long IdPaciente1
        {
            get
            {
                return IdPaciente;
            }

            set
            {
                IdPaciente = value;
            }
        }

        public long IdEmpleado1
        {
            get
            {
                return IdEmpleado;
            }

            set
            {
                IdEmpleado = value;
            }
        }

        public DateTime FechaSolicitud1
        {
            get
            {
                return FechaSolicitud;
            }

            set
            {
                FechaSolicitud = value;
            }
        }

        public DateTime FechaCita1
        {
            get
            {
                return FechaCita;
            }

            set
            {
                FechaCita = value;
            }
        }

        public TimeSpan HoraCita1
        {
            get
            {
                return HoraCita;
            }

            set
            {
                HoraCita = value;
            }
        }

        public void PedirCita(long IdPaciente, long IdEmpleado, DateTime FechaSolicitud, DateTime FechaCita, TimeSpan HoraCita)
        {
            Adaptador.spr_AgregarCitas(IdPaciente, IdPaciente, FechaSolicitud, FechaCita, HoraCita);
        }

        public void ModificarCita(long IdPaciente, long IdEmpleado, DateTime FechaSolicitud, DateTime FechaCita, TimeSpan HoraCita)
        {
            Adaptador.spr_ActualizarCita(IdEmpleado, FechaSolicitud, FechaCita, HoraCita, IdPaciente);
        }
        public void CancelarCita(long IdPaciente)
        {
            Adaptador.spr_CancelarCita(IdPaciente);
        }
    }
}
