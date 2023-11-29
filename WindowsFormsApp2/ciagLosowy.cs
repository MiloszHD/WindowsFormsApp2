using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class ciagLosowy
    {
        private static Random random = new Random();

        public static void Losowy(int Length)
        {
            if (Length <= 0)
            {
                Console.WriteLine("ciag losowy jest pusty");
                return;
            }

            for(int i = 0; i < Length; i++) 
            {
                int losowyNumer = random.Next();
                Console.WriteLine(losowyNumer);
            }
                
        }
    }
}
