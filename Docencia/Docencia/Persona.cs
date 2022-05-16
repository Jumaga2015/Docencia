using System;

namespace Docencia
{
    public class Persona
    {
        public string Nombre { get; }
        public string Ape1 { get;  }
        public string Ape2 { get;  }
        public DateTime FechaNacimiento { get; }

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="ape1">Primer Apellido de la persona</param>
        /// <param name="ape2">Segundo Apellido de la persona</param>
        public Persona(string nombre, string ape1, string ape2)
        {
            Nombre = nombre;
            Ape1 = ape1;
            Ape2 = ape2;
        }

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="ape1">Primer Apellido de la persona</param>
        /// <param name="ape2">Segundo Apellido de la persona</param>
        /// <param name="fechaNacimiento">Fecha de Nacimiento</param>
        public Persona(string nombre, string ape1, string ape2, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Ape1 = ape1;
            Ape2 = ape2;
            FechaNacimiento = fechaNacimiento;
        }

        public virtual string DameInfo()
        {
            return Ape1 + " " + Ape2 + ", " + Nombre;
        }

        public string DameInfoExtendida()
        {
            return DameInfo() + " Edad: " + (DateTime.Now - FechaNacimiento).Days.ToString() + " Dias";
        }
    }
}
