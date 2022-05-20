using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docencia.Formacion
{
    public class Cualificacion
    {

        public string Denominacion { get; }
        public Dictionary<string, UnidadDeCompetencia> UnidadesDeCompetencia;
        
        public Cualificacion(string denominacion)
        {
            Denominacion = denominacion;
            UnidadesDeCompetencia = new Dictionary<string, UnidadDeCompetencia>();
        }

        public void Agregar(UnidadDeCompetencia unidadDeCompetencia)
        {
            UnidadesDeCompetencia.Add(unidadDeCompetencia.Codigo)
        }

    }
}
