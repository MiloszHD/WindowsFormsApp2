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
            int[] ilo = new int[liczby.Length];

            Array.Copy(liczby, ilo, liczby.Length);

            zacznij();
            szybkoo(ilo, left, right);
            zatrzymaj();
        }
        public static void szybkoo(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                
                if(i <= j)
                {
                    int tym= array[i];
                    array[i++] = array[j];
                    array[j--] = tym;
                }
            }
            if(i < right) szybkoo(array, i, right);
            if(left < j) szybkoo(array, left, j);
        }
    }
}
