using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sorWstaw : timer
    {
        
        public void wstaw(int[] liczby)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            zacznij();
            for (int i = 0; i < liczby.Length; ++i)
            {
                int current = dos[i];
                int j = i - 1;

                while(j >= 0 && dos[j] > current)
                {
                    dos[j+1] = dos[j];
                    j = j - 1;
                }
                dos[j+1] = current;
            }
            zatrzymaj();
        }
    }
}
