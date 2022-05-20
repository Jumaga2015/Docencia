using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docencia.Formacion
{
    public class ModuloFormativo : BaseFormativa
    {
        public List<UnidadFormativa> UnidadesFormativas;

        public ModuloFormativo(string nombre): base(nombre)
        {
            UnidadesFormativas = new List<UnidadFormativa>();
        }
    }
}
