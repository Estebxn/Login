using Datos_1.DSLoginTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DiagnosticoPaciente
    {
        long IdPaciente;
        long IdDiagnostico;
        string Diagnostico;

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

        public long IdDiagnostico1
        {
            get
            {
                return IdDiagnostico;
            }

            set
            {
                IdDiagnostico = value;
            }
        }

        public string Diagnostico1
        {
            get
            {
                return Diagnostico;
            }

            set
            {
                Diagnostico = value;
            }
        }

        private static DiagnosticoTableAdapter Adaptador = new DiagnosticoTableAdapter();
        public void GenerarDiagnostico(long IdPaciente, long IdDiagnostico, string Diagnostico)
        {
            Adaptador.spr_GenerarDiagnostico(IdPaciente, IdDiagnostico, Diagnostico);
        }

        public void EditarDiagnostico(long IdPaciente, long IdDiagnostico, string Diagnostico)
        {
            Adaptador.spr_EditarDiagnostico(IdPaciente, Diagnostico, IdDiagnostico);
        }
        public void EliminarDiagnostico(long IdDiagnostico)
        {
            Adaptador.spr_EliminarDiagnostico(IdDiagnostico);
        }
    }
}

