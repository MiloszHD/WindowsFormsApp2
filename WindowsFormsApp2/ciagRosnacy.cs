using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class ciagRosnacy
    {
        public static void Rosnacy(int Length)
        {
            if(Length <= 0) 
            {
                Console.WriteLine("ciag rosnacy jest pusty");
                return;
            }

            for(int i = 1; i<= Length; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
