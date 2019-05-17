using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Prestamos
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());

            frmLogin menu = new frmLogin();
            //frmMenu menu = new frmMenu();
                
            menu.Show();
            Application.Run();
        }
    }
}
