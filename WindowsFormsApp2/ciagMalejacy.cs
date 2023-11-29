using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class ciagMalejacy
    {
        public static void Malejacy(int Length) 
        {
            if (Length <= 0)
            {
                Console.WriteLine("Ciag malejacy jest pusty");
                return;
            }

            for(int i = Length; i>=1; i--) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
