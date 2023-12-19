using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sorBab : timer
    {
        public void babel(int[] liczby)
        {
            int[] dos = new int[liczby.Length];
            for(int k = 0; k <liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            zacznij();
            for (int i = 0; i < liczby.Length - 1; i++)
            {
                for (int j = 0; j < liczby.Length - i - 1; j++)
                    if (liczby[j] > liczby[j + 1])
                    {
                        int temp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = temp;
                    }
            }
            zatrzymaj();
        }

    }
}
