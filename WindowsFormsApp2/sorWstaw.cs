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
            int[] ilo = new int[liczby.Length];

            Array.Copy(liczby, ilo, liczby.Length);

            zacznij();
            for (int i = 0; i < liczby.Length; ++i)
            {
                int ob = ilo[i];
                int j = i - 1;

                while(j >= 0 && ilo[j] > ob)
                {
                    ilo[j+1] = ilo[j];
                    j = j - 1;
                }
                ilo[j+1] = ob;
            }
            zatrzymaj();
        }
    }
}
