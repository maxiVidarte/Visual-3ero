using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCuentaOffShore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmPrincipal frmPrinc;
           
            try
            {
                frmPrinc = new FrmPrincipal();
                Application.Run(frmPrinc);
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
