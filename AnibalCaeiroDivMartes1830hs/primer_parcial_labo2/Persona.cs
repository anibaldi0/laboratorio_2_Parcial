using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace primer_parcial_labo2
{
    public abstract class Persona
    {
        protected string apellido;
        protected DateTime nacimiento;
        protected string nombre;

        public string NombreCompleto => $"{apellido}, {nombre}";
        public int Edad => CalcularEdad();

        public abstract string FichaExtra();

        public override string ToString() => NombreCompleto;

        public virtual string FichaPersonal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{NombreCompleto}");
            sb.AppendLine($"EDAD: {Edad}");
            return sb.ToString();
        }

        protected Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - nacimiento.Year;
            if (nacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
    }
}


