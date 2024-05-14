using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_labo2
{
    public class Paciente : Persona
    {
        private string barrio;
        private string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrio, string diagnostico) : base(nombre, apellido, nacimiento)
        {
            this.barrio = barrio;
            this.diagnostico = diagnostico;
        }

        public override string FichaExtra()
        {
            return $"Recide en: {barrio}\n{diagnostico}";
        }
    }
}
