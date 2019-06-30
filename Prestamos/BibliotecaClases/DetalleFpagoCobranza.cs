using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class DetalleFpagoCobranza
    {
        public FormaPago cheque { get; set; }
        public int numeroCheque { get; set; }
        public DateTime fechaCheque { get; set; }
        public int montoCheque { get; set; }
        

        public static List<DetalleFpagoCobranza> ListaDetallefpagoCobranza = new List<DetalleFpagoCobranza>();

        public static void Agregar (DetalleFpagoCobranza d)
        {
            ListaDetallefpagoCobranza.Add(d);
        }

        public static List<DetalleFpagoCobranza> ObtenerDetalles()
        {
            return ListaDetallefpagoCobranza;
        }
        public static int ObtenerTotal()
        {
            
            int total=0;
            foreach (DetalleFpagoCobranza d in ListaDetallefpagoCobranza)
            {
                total = total+ d.montoCheque;
            }
            
            
            return total;
        }
    }
}
