using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sorScal : timer
    {
        public void scalanie(int[] liczby, int left, int right)
        {
            int[] sca = new int[liczby.Length];

            Array.Copy(liczby, sca, liczby.Length);

            zacznij();
            scalanie2(sca, left, right);
            zatrzymaj();
        }
        public void scal(int[] ilo, int left, int mid, int right)
        {
            int i = left, j = mid + 1;

            int[] cos = new int[ilo.Length];

            for (int m = left; m < ilo.Length; m++)
            {
                cos[m] = ilo[m];
            }

            for (int k = left; k <= right; k++)
                if (i <= mid)
                {
                    if (j <= right)
                    {
                        if (cos[j] < cos[i])
                        {
                            ilo[k] = cos[j++];
                        }
                        else
                        {
                            ilo[k] = cos[i++];
                        }
                    }
                    else
                    {
                        ilo[k] = cos[i++];
                    }
                }
                else
                {
                    ilo[k] = cos[j++];
                }
        }
        public void scalanie2(int[] dos, int left, int right)
        {

            if (right <= left)
            {
                return;
            }

            int srodek = (right + left) / 2;


            scalanie2(dos, left, srodek);
            scalanie2(dos, srodek + 1, right);


            scal(dos, left, srodek, right);
        }

    }
}
