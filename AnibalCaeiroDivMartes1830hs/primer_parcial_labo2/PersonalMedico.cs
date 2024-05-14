using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_labo2
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool finalizoResidencia;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool finalizoResidencia) : base(nombre, apellido, nacimiento)
        {
            this.finalizoResidencia = finalizoResidencia;
            consultas = new List<Consulta>();
        }

        public void AgregarConsulta(Consulta consulta)
        {
            consultas.Add(consulta);
        }

        public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó residencia? {(finalizoResidencia ? "SI" : "NO")}");
            sb.AppendLine("ATENCIONES:");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }
            return sb.ToString();
        }

        public static PersonalMedico operator +(PersonalMedico medico, Consulta consulta)
        {
            medico.AgregarConsulta(consulta);
            return medico;
        }
    }
}
