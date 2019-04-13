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
        public int MontoTotal {get; set;}
        public int CantidadCuota {get; set;}
        public int InteresGenerado {get; set;}
        public int NumeroCliente {get; set;}
        public int Saldo { get; set; }

        public Prestamo(){}

    }
}
