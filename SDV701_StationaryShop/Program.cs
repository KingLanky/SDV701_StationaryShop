using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryWinForm
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
            clsPen.LoadPenForm = new clsPen.LoadPenFormDelegate(frmPen.Run);
            clsPencil.LoadPencilForm = new clsPencil.LoadPencilFormDelegate(frmPencil.Run);
            Application.Run(frmMain.Instance);

        }
    }
}
