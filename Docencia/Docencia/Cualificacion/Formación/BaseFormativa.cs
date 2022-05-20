using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docencia.Formacion
{
    
    public class BaseFormativa
    {
        public string Nombre { get; }

        private double Nota;

        public BaseFormativa(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void EstableceNota(double nota)
        {
            Nota = nota;
        }

        public virtual double DevuelveNota()
        {
            return 0.0;
        }

    }
}
