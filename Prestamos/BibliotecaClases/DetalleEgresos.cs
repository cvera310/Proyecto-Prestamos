using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   public  class DetalleEgresos
    {
        public enum TipoEgreso
        {
            Alimentacion,
            Alquiler,
            Pago_Servicios_Basicos,
            Transporte,
            Educacion,
            Otros

        }


        public TipoEgreso tipo_egreso { get; set; }
        public double monto_egreso { get; set; }

    }
}
