using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docencia 
{
    public class Docente : Persona
    {
        public string Nss { get; }

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="ape1">Primer Apellido de la persona</param>
        /// <param name="ape2">Segundo Apellido de la persona</param>
        /// <param name="nss">Número seguridad social</param>
        public Docente(string nombre, string ape1, string ape2, string nss) : base(nombre, ape1, ape2)
        {
            Nss = nss;
        }

        public override string DameInfo()
        {
            return Ape1 + " " + Ape2 + ", " + Nombre + " Actuación Docente(" + Nss + ")";
        }
    }
}
