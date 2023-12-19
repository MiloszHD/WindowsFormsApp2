using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sorWybor : timer
    {
        public static void wybor(int[] liczby)
        {
            int[] ilo = new int[liczby.Length];

            Array.Copy(liczby, ilo, liczby.Length);

            zacznij();
            for (int i=0; i<liczby.Length - 1; i++)
            {
                int min_index = i;

                for(int j = i+1; j< liczby.Length; j++)
                    
                    if (ilo[j] < ilo[min_index])
                    {
                        min_index = j;
                    }
                        
                int tym = ilo[min_index];
                ilo[min_index] = ilo[i];
                ilo[i] = tym;
            }

            zatrzymaj();
        }
    }
}
