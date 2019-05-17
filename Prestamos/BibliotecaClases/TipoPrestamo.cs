using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class TipoPrestamo
    {
        public String Codigo { get; set; }
        public String Descripcion {get; set;}
        public double InteresBase {get; set;}

        public static List<TipoPrestamo> ListaTipoPrestamo = new List<TipoPrestamo>();

        public static void Agregar (TipoPrestamo tp)
        {
            ListaTipoPrestamo.Add(tp);
        }

        public static void Eliminar (TipoPrestamo tp)
        {
            ListaTipoPrestamo.Remove(tp);
        }

        public static List<TipoPrestamo> ObtenerTipoPrestamo()
        {
            return ListaTipoPrestamo;
        }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
