using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_opdrachten
{
    internal class Timer
    {
        public int value { get; set; }
        public int limit { get; set; }
        public int seconds { get; set; }

        public Timer(int limit)
        {
            this.limit = limit;
            this.value = 0;
        }

        public void Advance()
        {
            this.value++;

            if (this.value >= this.limit)
            {
                this.value = 0;
                this.seconds++;
            }
        }

        public override string ToString()
        {
            string miliseconds = "";
            string seconds = "";
            if (this.value < 10)
            {
                miliseconds = "0" + this.value;
            } else { 
            miliseconds = this.value.ToString();
            }
            if (this.seconds < 10)
            {
                seconds = "0" + this.seconds;
            } else {  seconds = this.seconds.ToString(); }

            return seconds + ":" + miliseconds;
        }

        public bool StopTimer()
        {
            if (this.seconds >= 60)
            {
                return true;
            }
            return false;
        }
    }
}

