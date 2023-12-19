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
            int[] num = new int[liczby.Length];
            
            Array.Copy(liczby, num, liczby.Length);

            zacznij();
            for (int i = 0; i < liczby.Length - 1; i++)
            {
                for (int j = 0; j < liczby.Length - i - 1; j++)
                    if (num[j] > num[j + 1])
                    {
                        int tm = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = tm;
                    }
            }
            zatrzymaj();
        }

    }
}
