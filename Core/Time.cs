using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace BlinkByte
{
    public static class Time
    {
        static Stopwatch time = new Stopwatch();
        public static float deltaTime
        {
            get
            {
                return (float)ElapsedTime.TotalMilliseconds;
            }
        }
        public static TimeSpan ElapsedTime
        {
            get
            {
                return time.Elapsed;
            }
        }
        public static void Reset()
        {
            time.Restart();
        }
    }
}
