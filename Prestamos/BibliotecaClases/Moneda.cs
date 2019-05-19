using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Moneda
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }
        public String PaisProcedencia { get; set; }

        //public List<MonedaDetalle> detalle_moneda = new List<MonedaDetalle>();
       // public String CantidadDisponible { get; set; }

        public static List<Moneda> ListaMoneda = new List<Moneda>();

        public static void Agregar (Moneda m)
        {
            ListaMoneda.Add(m);
        }
      
        public static void Eliminar (Moneda m)
        {
            ListaMoneda.Remove(m);
        }

        public static List<Moneda> ListarMoneda()
        {
            return ListaMoneda;
        }

        public override string ToString()
        {
            return Descripcion;
        }
         
        public static List<Moneda> ObtenerMoneda()
        {
            return ListaMoneda;
        }
    }
}
