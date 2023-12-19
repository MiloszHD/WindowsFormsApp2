using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
     public abstract class timer
    {
        private static DateTime startTime, stopTime;
        public Double czas
        {
            get
            {
                if(startTime != DateTime.MinValue && stopTime != DateTime.MinValue) 
                {
                    TimeSpan elapsed = stopTime - startTime;
                    return elapsed.TotalMilliseconds;
                }
                else
                {
                    return(0);
                }
            }
        }
        public static void zacznij()
        {
            startTime = DateTime.Now;
        }
        public static void zatrzymaj()
        {
            stopTime = DateTime.Now;
        }
    }
}
