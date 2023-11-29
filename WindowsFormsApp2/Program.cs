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

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            sortowanieBabel(ints);
            Pokaz(ints);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void sortowanieBabel(int[] ints)
        {
            int n = ints.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (ints[i] > ints[j + 1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }

        }

        private static void Pokaz(int[] ints)
        {
            int n = ints.Length;

            for(int i = 0;i < n ;++i)
                Console.WriteLine(ints[i]+ " ");
            Console.WriteLine();
        }
    }
}
