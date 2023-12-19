using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sorSzybkie : timer
    {
        public void szybko(int[] liczby, int left, int right)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            zacznij();
            szybkoo(dos, left, right);
            zatrzymaj();
        }
        public static void szybkoo(int[] sliczby, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = sliczby[(left + right) / 2];
            while (i < j)
            {
                while (sliczby[i] < pivot) i++;
                while (sliczby[j] > pivot) j--;
                if(i <= j)
                {
                    int tmp= sliczby[i];
                    sliczby[i++] = sliczby[j];
                    sliczby[j--] = tmp;
                }
            }
            if(left < j) szybkoo(sliczby, left, j);
            if(i < right) szybkoo(sliczby, i, right);
        }
    }
}
