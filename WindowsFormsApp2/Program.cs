using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ciagMalejacy.Malejacy(5);
            ciagRosnacy.Rosnacy(5);
            ciagLosowy.Losowy(5);

    
        }

    }
}
