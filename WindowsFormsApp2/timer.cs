using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
     public abstract class timer
    {
        private static DateTime start, stop;
        public Double duration
        {
            get
            {
                if(start != null && stop != null) 
                { 
                    return(stop - start).TotalMilliseconds;
                }
                else
                {
                    return(0);
                }
            }
        }
        public static void StartCount()
        {
            start = DateTime.Now;
        }
        public static void StopCount()
        {
            stop = DateTime.Now;
        }
    }
}
