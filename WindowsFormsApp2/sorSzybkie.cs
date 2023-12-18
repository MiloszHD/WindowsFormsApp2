using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sorSzybkie : timer
    {
        public static void szybko(int[] liczby, int left, int right)
        {
            start = DateTime.Now;
            int i = left;
            int j = right;
            int pivot = liczby[(left + right) / 2];
            while (i < j)
            {
                while (liczby[i] < pivot) i++;
                while (liczby[j] > pivot) j--;
                if(i <= j)
                {
                    int tmp= liczby[i];
                    liczby[i++] = liczby[j];
                    liczby[j--] = tmp;
                }
            }
            if(left < j) szybko(liczby, left, j);
            if(i < right) szybko(liczby, i, right);
            stop = DateTime.Now;
        }
    }
}
