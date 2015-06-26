using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzverwaltung
{
    class Zeitspanne
    {
        public Time start;
        Time end;

        public Zeitspanne()
        {
            this.start = new Time();
            this.end = new Time();
        }

        public Zeitspanne(Time _start, Time _end)
        {
            this.start = _start;
            this.end = _end;
        }

        public bool checkOverlap(Zeitspanne x)
        {
            if ((this.start.laterOrEqual(x.start) && this.start.earlierThan(x.end)) || (x.start.laterOrEqual(this.start) && x.start.earlierThan(this.end)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
