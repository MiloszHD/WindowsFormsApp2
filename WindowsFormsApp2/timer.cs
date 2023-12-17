using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract public class timer
    {
        private DateTime start, stop;
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
    }
}
