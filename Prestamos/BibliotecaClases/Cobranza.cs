using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cobranza : Prestamo
    {
        public String FormaPago { get; set; }
        public String Medio { get; set; }
        public String Monto { get; set; }
        public String NroPrestamo { get; set; }

        public Cobranza() { }
    }
}
