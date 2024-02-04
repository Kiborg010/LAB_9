using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_1
{
    public class DialClock
    {
        int hour;
        int minute;
        static int count = 0;

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 0)
                {
                    int hourAux = value % 24;
                    hour = 24 + hourAux;
                }
                else if (value > 23)
                {
                    hour = value % 24;
                }
                else
                {
                    hour = value;
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                {
                    int minuteAux = value % 60;
                    int hourAux = value / 60;
                    hour += hourAux;
                    hour -= 1;
                    minute = 60 + minuteAux;
                    hour = hour % 24;
                    if (hour < 0)
                    {
                        hour = 24 + hour;
                    }
                    else if (minute == 60)
                    {
                        hour += 1;
                        minute = 0;
                    }
                }
                else if (value > 59)
                {
                    hour += (value / 60);
                    hour = hour % 24;
                    minute = value % 60;
                }
                else
                {
                    minute = value;
                }
            }
        }

        public DialClock()
        {
            Hour = 0;
            Minute = 0;
            count += 1;
        }

        public DialClock(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
            count += 1;
        }

        public DialClock(DialClock other)
        {
            this.Hour = other.Hour;
            this.Minute = other.Minute;
            count += 1;
        }

        public string Show()
        {
            return $"{hour} ч. {minute} мин.";
        }

        public static double Corner(DialClock DC)
        {
            double corner;
            int hourZ = DC.hour;
            int hour = DC.hour % 12;
            int minute = DC.minute;
            if (minute > hour * 5)
            {
                corner = (minute - (hour * 5)) * 6 - minute * 0.5;
            }
            else if(minute < hour * 5)
            {
                corner = ((hour * 5) - minute) * 6 + minute * 0.5;
            }
            else
            {
                corner = minute * 0.5;
            };
            if (corner > 180)
            {
                return 360 - corner;
            };
            DC.Hour = hourZ;
            return corner;
        }

        public double Corner()
        {
            double corner;
            int hourZ = hour;
            hour = hour % 12;
            if (minute > hour * 5)
            {
                corner = (minute - (hour * 5)) * 6 - minute * 0.5;
            }
            else if (minute < hour * 5)
            {
                corner = ((hour * 5) - minute) * 6 + minute * 0.5;
            }
            else
            {
                corner = minute * 0.5;
            };
            if (corner > 180)
            {
                return 360 - corner;
            };
            hour = hourZ;
            return corner;
        }

        public static int GetCount()
        {
            return count;
        }

        public static DialClock operator ++(DialClock DC)
        {
            DialClock result = new DialClock(DC);
            result.Minute = result.Minute + 1;
            return result;
        }

        public static DialClock operator --(DialClock DC)
        {
            DialClock result = new DialClock(DC);
            result.Minute = result.Minute - 1;
            return result;
        }

        public static explicit operator bool(DialClock DC)
        {
            if (DC.Corner() % 2.5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static implicit operator int(DialClock DC)
        {
            return DC.Minute / 5;
        }

        public static DialClock operator +(DialClock DC1, DialClock DC2)
        {
            DialClock result = new DialClock();
            result.Minute = DC1.Minute + DC2.Minute;
            result.Hour = DC1.Hour + DC2.Hour;
            return result;
        }

        public static DialClock operator +(int minute, DialClock DC)
        {
            DialClock temp = new DialClock();
            temp.Hour = DC.Hour;
            temp.Minute = DC.Minute + minute;
            return temp;
        }

        public static DialClock operator +(DialClock DC, int minute)
        {
            DialClock temp = new DialClock();
            temp.Hour = DC.Hour;
            temp.Minute = DC.Minute + minute;
            return temp;
        }

        public static DialClock operator -(DialClock DC1, DialClock DC2)
        {
            DialClock result = new DialClock();
            result.Minute = DC1.Minute - DC2.Minute;
            result.Hour = DC1.Hour - DC2.Hour;
            return result;
        }

        public static DialClock operator -(int minute, DialClock DC)
        {
            DialClock temp = new DialClock();
            temp.Hour = 0 - DC.Hour;
            temp.Minute = DC.Minute - minute;
            return temp;
        }

        public static DialClock operator -(DialClock DC, int minute)
        {
            DialClock temp = new DialClock();
            temp.Hour = DC.Hour;
            temp.Minute = DC.Minute - minute;
            return temp;
        }

        public override bool Equals(object obj)
        {
            if (obj is DialClock)
            {
                DialClock DC = (DialClock)obj;
                return (minute == DC.minute) && (hour == DC.hour);
            }
            return false;
        }
    }
}
