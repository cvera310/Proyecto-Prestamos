using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
  
    public class Prestamo : TipoPrestamo
    {
        public int NumeroPrestamo {get; set;}
        public int MontoSolicitado { get; set; }
        public double MontoTotal {get; set;}
        public int CantidadCuota {get; set;}
        public int InteresGenerado {get; set;}
        public Cliente cliente {get; set;}
        public double Saldo { get; set; }
        public Moneda moneda { get; set; }
        public TipoPrestamo tipoPrestamo { get; set; }
        public DateTime Fecha { get; set; }

        public static List <Prestamo> ListaPrestamo = new List<Prestamo>();
        public static void Agregar (Prestamo p)
        {
            ListaPrestamo.Add(p);
        }

        public static void Eliminar (Prestamo p)
        {
            ListaPrestamo.Add(p);
        }

        public static List<Prestamo> ObtenerPrestamo()
        {
            return ListaPrestamo;
        }

    }
}
