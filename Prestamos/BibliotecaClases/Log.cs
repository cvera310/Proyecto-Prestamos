using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Log
    {
        private const string ArchivoLog = "log.txt";
        private const string Separador = ";";
        public static void EscribirLog(string TipoError, string Error)
        {
            using (StreamWriter w = File.AppendText(ArchivoLog))
            {
                string FechaHora = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToLongTimeString();
                string linea = FechaHora + Separador + TipoError + Separador + Error;
                w.WriteLine(linea);

            }


        }

    }
}
