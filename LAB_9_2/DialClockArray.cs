using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_1
{
    public class DialClockArray
    {
        DialClock[] array;
        static int lenght;
        static int countObject;
        static int countCollection;
        public DialClockArray()
        {
            array = new DialClock[0];
            countCollection++;
        }

        public DialClockArray(int[,] DCA)
        {
            int hour;
            int minute;
            lenght = DCA.GetLength(0);
            array = new DialClock[DCA.GetLength(0)];
            for (int i = 0; i < DCA.GetLength(0); i++)
            {
                hour = DCA[i, 0];
                minute = DCA[i, 1];
                array[i] = new DialClock(hour, minute);
                countObject++;
            };
            countCollection++;
        }

        public DialClockArray(int count)
        {
            lenght = count;
            array = new DialClock[count];
            for (int i = 0; i < count; i++)
            {
                Random rand = new Random();
                int hour = rand.Next(0, 23);
                int minute = rand.Next(0, 59);
                array[i] = new DialClock(hour, minute);
                countObject++;
            };
            countCollection++;
        }

        public DialClockArray(DialClockArray other)
        {
            this.array = new DialClock[other.Lenght()];
            for (int i = 0; i < other.Lenght(); i++)
            {
                this.array[i] = new DialClock(other.array[i]);
            }
            countCollection++;
        }

        public DialClock this[int index]
        {
            get
            {
                if ((index < lenght) && (index >= 0))
                {
                    return array[index];
                }
                else
                {
                    throw new Exception("Выход за границы массива");
                }
            }
            set
            {
                if ((index < lenght) && (index >= 0))
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("Выход за границы массива");
                }

            }
        }

        public int Lenght()
        {
            return lenght;
        }

        public string Show()
        {
            if (lenght > 0)
            {
                string result = "";
                for (int i = 0; i < lenght; i++)
                {
                    result += array[i].Show();
                    result += "\n";
                };
                return result;
            }
            else
            {
                return "В массиве нет элементов";
            }
        }

        public static int GetCountObject()
        {
            return countObject;
        }

        public static int GetCountCollection()
        {
            return countCollection;
        }
    }
}
