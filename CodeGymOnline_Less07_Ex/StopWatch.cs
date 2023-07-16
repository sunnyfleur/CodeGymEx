using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less07_Ex
{
    internal class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime { get => startTime;  }
        public DateTime EndTime { get => endTime;  }

        public StopWatch()
        {
            startTime=DateTime.Now;
        }

        public void Start()
        {
            this.startTime= DateTime.Now;
        }
        public void End()
        {
            this.endTime= DateTime.Now;
        }
        public double ElapsedTime()
        {
            return (endTime-startTime).TotalMilliseconds;
        }
    }
}
