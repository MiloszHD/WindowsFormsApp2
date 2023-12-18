using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sorScal
    {
        private static DateTime start, stop;
        public Double duration
        {
            get
            {
                if (start != null && stop != null)
                {
                    return (stop - start).TotalMilliseconds;
                }
                else
                {
                    return (0);
                }
            }
        }
        public static void scalanie(int[] liczby, int left, int right)
        {
            start = DateTime.Now;

            if (left < right)
            {
                int middle = (left + right) / 2;

                // Sortuj lewą i prawą część
                scalanie(liczby, left, middle);
                scalanie(liczby, middle + 1, right);

                // Scal posortowane części
                Scal(liczby, left, middle, right);
            }

            stop = DateTime.Now;
        }

        public static void Scal(int[] liczby, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] LeftArray = new int[n1];
            int[] RightArray = new int[n2];

            // Skopiuj dane do pomocniczych tablic
            for (int i = 0; i < n1; ++i)
                LeftArray[i] = liczby[left + i];
            for (int j = 0; j < n2; ++j)
                RightArray[j] = liczby[middle + 1 + j];

            // Scal dane z powrotem do tablicy
            int x = 0, y = 0;
            int k = left;
            while (x < n1 && y < n2)
            {
                if (LeftArray[x] <= RightArray[y])
                {
                    liczby[k] = LeftArray[x];
                    x++;
                }
                else
                {
                    liczby[k] = RightArray[y];
                    y++;
                }
                k++;
            }

            // Skopiuj pozostałe elementy z LeftArray (jeśli są)
            while (x < n1)
            {
                liczby[k] = LeftArray[x];
                x++;
                k++;
            }

            // Skopiuj pozostałe elementy z RightArray (jeśli są)
            while (y < n2)
            {
                liczby[k] = RightArray[y];
                y++;
                k++;
            }
        }
    }
}
