namespace Docencia.Formacion
{
    public class UnidadDeCompetencia
    {

        public Cualificacion Cualificacion { get; }

        public string Codigo { get; }
        public string Nombre { get; }

        public UnidadFormativa UnidadFormativa { get; }

        public UnidadDeCompetencia(Cualificacion cualificacion, string codigo, string nombre)
        {
            Cualificacion = cualificacion;
        }

    }
}