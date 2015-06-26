using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzverwaltung
{
    class Time
    {
        int hour;
        int minute;

        public Time()
        {
            this.hour = 0;
            this.minute = 0;
        }

        public Time(int h, int m)
        {
            this.hour = h % 24;
            this.minute = m % 60;
        }

        public bool earlierThan(Time x)
        {
            if (this.hour < x.hour)
            {
                return true;
            }
            else if (this.hour == x.hour && this.minute < x.minute)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool laterThan(Time x)
        {
            if (this.hour > x.hour)
            {
                return true;
            }
            else if (this.hour == x.hour && this.minute > x.minute)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ealierOrEqual(Time x)
        {
            return !this.laterThan(x);
        }

        public bool laterOrEqual(Time x)
        {
            return !this.earlierThan(x);
        }
    }
}
