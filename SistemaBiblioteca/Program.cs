using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            View.Frm_login _login = new View.Frm_login();
            Controller.cls_login _log = new Controller.cls_login(_login);
            Application.Run(_login);
        }
    }
}
