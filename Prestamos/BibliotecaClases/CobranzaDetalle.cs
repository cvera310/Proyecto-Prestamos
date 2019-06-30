using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   public class CobranzaDetalle
    {
        public int cobranzaId { get; set; }
        public int prestamoId { get; set; }
        public int mora { get; set; }
        public int dcto { get; set; }

        
    }
}
