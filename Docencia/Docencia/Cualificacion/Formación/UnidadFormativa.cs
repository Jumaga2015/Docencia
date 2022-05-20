using System.Collections.Generic;

namespace Docencia.Formacion
{
    public class UnidadFormativa : BaseFormativa
    {
        public List<PruebaFormativa> PruebasFormativa { get; }

        public UnidadFormativa(string nombre) : base(nombre)
        {

        }
    }
}