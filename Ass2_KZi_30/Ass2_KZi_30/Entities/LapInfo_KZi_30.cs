using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_KZi_30.Entities
{
    class LapInfo_KZi_30
    {
        public TimeSpan start { get; set; }
        public TimeSpan end { get; set; }
        public TimeSpan duration { get; set; }

        public LapInfo_KZi_30(TimeSpan newStartTime, TimeSpan newEndTime, TimeSpan newDuration)
        {
            start = newStartTime;
            end = newEndTime;
            duration = newDuration;
        }
        public LapInfo_KZi_30() { }


    }
}
