using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_1
{
    internal class Programm
    {
        static DialClock MaxCorner(DialClockArray DCA)
        {
            double max = -11111111;
            DialClock el = DCA[0];
            for (int i = 0; i < DCA.Lenght(); i++)
            {
                if (DCA[i].Corner() > max)
                {
                    max = DCA[i].Corner();
                    el = DCA[i];
                }
            }
            return el;
        }

        static DialClock InputDialClock()
        {
            Console.Write($"Введите количество часов элемента: ");
            int hour;
            bool hourIsCorrected = int.TryParse(Console.ReadLine(), out hour);
            while (!hourIsCorrected)
            {
                Console.WriteLine("Ошибка ввода. Вам необходимо ввести целое число");
                Console.Write($"Введите количество часов элемент: ");
                hourIsCorrected = int.TryParse(Console.ReadLine(), out hour);
            };
            Console.Write($"Введите количество минут элемента: ");
            int minute;
            bool minuteIsCorrected = int.TryParse(Console.ReadLine(), out minute);
            while (!minuteIsCorrected)
            {
                Console.WriteLine("Ошибка ввода. Вам необходимо ввести целое число");
                Console.Write($"Введите количество минут элемента: ");
                minuteIsCorrected = int.TryParse(Console.ReadLine(), out minute);
            };
            return new DialClock(hour, minute);

        }

        static DialClockArray InputDialCLockArray()
        {
            Console.Write("Введите способ создания элементов массива (0 - ручной ввод, 1 - случайная генерация): ");
            int number;
            bool numberIsCorrected = int.TryParse(Console.ReadLine(), out number);
            while (!(numberIsCorrected && (number >= 0) && (number <= 1)))
            {
                Console.WriteLine("Ошибка ввода. Вам необходимо ввести целое число от 0 до 1");
                Console.Write("Введите способ создания элементов массива (0 - ручной ввод, 1 - случайная генерация): ");
                numberIsCorrected = int.TryParse(Console.ReadLine(), out number);
            };
            Console.Write($"Введите количество элементов типа DialClock: ");
            int countEl;
            bool countElIsCorrected = int.TryParse(Console.ReadLine(), out countEl);
            while (!((countElIsCorrected) && (countEl > 0)))
            {
                Console.WriteLine("Ошибка ввода. Вам необходимо ввести целое положительное число");
                Console.Write($"Введите количество элементов типа DialClock: ");
                countElIsCorrected = int.TryParse(Console.ReadLine(), out countEl);
            };
            if (number == 0)
            {
                int[,] array = new int[countEl, 2];
                for (int i = 0; i < countEl; i++)
                {
                    Console.WriteLine($"Вам нужно ввести ещё элементов: {countEl - i}");
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write($"Введите количество часов элемента №{j + 1}: ");
                            int hour;
                            bool hourIsCorrected = int.TryParse(Console.ReadLine(), out hour);
                            while (!hourIsCorrected)
                            {
                                Console.WriteLine("Ошибка ввода. Вам необходимо ввести целое число");
                                Console.Write($"Введите количество часов элемента №{i + 1}: ");
                                hourIsCorrected = int.TryParse(Console.ReadLine(), out hour);
                            };
                            array[i, j] = hour;
                        }
                        else
                        {
                            Console.Write($"Введите количество минут элемента №{i + 1}: ");
                            int minute;
                            bool minuteIsCorrected = int.TryParse(Console.ReadLine(), out minute);
                            while (!minuteIsCorrected)
                            {
                                Console.WriteLine("Ошибка ввода. Вам необходимо ввести целое число");
                                Console.Write($"Введите количество минут элемента №{i + 1}: ");
                                minuteIsCorrected = int.TryParse(Console.ReadLine(), out minute);
                            }
                            array[i, j] = minute;
                        }
                    }
                }
                return new DialClockArray(array);
            }
            else
            {
                return new DialClockArray(countEl);
            }
        }
        static void Main()
        {
            DialClock DC1 = new DialClock();
            Console.WriteLine($"DialClock(): {DC1.Show()}");
            DialClock DC2 = new DialClock(1, 1);
            Console.WriteLine($"DialClock(1, 1): {DC2.Show()}");
            DialClock DC3 = new DialClock(-2, -2);
            Console.WriteLine($"DialClock(-2, -2): {DC3.Show()}");
            DialClock DC4 = new DialClock(25, 61);
            Console.WriteLine($"DialClock(25, 61): {DC4.Show()}");
            DialClock DC5 = new DialClock(23, 59);
            Console.WriteLine($"DialClock(23, 59): {DC5.Show()}");
            DC5++;
            Console.WriteLine($"DialClock(23, 59)++: {DC5.Show()}");
            DC5--;
            Console.WriteLine($"DialClock(0, 0)--: {DC5.Show()}");
            Console.WriteLine();
            for (int i = 0; i < 0; i++)
            {
                DialClock DC6 = InputDialClock();
                Console.WriteLine(DC6.Show());
                Console.WriteLine($"Угол: {DC6.Corner()}");
                Console.WriteLine();
            }
            DialClock DC7 = new DialClock(12, 24);
            Console.WriteLine($"DC7 = DialClock(12, 24): {DC7.Show()}");
            Console.WriteLine($"Угол с помощью метода класса (DC7.Corner()): {DC7.Corner()}");
            Console.WriteLine($"Угол с помощью статической функции (DialClock.Corner(DC7)): {DialClock.Corner(DC7)}");
            Console.Write($"Невное преобразование DC7: ");
            Console.WriteLine(DC7);
            Console.WriteLine($"Явное преобразование DC7 ((bool)DC7): {(bool)DC7}");

            Console.WriteLine();

            DialClock DC8 = new DialClock(1, 2);
            DialClock DC9 = new DialClock(3, 4);
            Console.WriteLine($"DC8 = DialClock(1, 2): {DC8.Show()}");
            Console.WriteLine($"DC9 = DialClock(3, 4): {DC9.Show()}");
            Console.WriteLine($"DC8 + DC9 =  {(DC8 + DC9).Show()}");
            Console.WriteLine($"DC8 - DC9 =  {(DC8 - DC9).Show()}");

            Console.WriteLine();

            Console.WriteLine("Копируем элемент DC8 как DC8_1.");
            DialClock DC8_1 = new DialClock(DC8);
            Console.WriteLine("Изменим DC8 на DialClock(3, 3)");
            DC8 = new DialClock(3, 3);
            Console.WriteLine($"Элемент DC8: {DC8.Show()}");
            Console.WriteLine($"Элемент DC8_1: {DC8_1.Show()}");

            Console.WriteLine();

            Console.WriteLine($"Количество созданных элементов типа DialClock: {DialClock.GetCount()}");

            Console.WriteLine();

            DialClockArray DCA1 = new DialClockArray();
            Console.WriteLine($"DialClockArray(): {DCA1.Show()}");

            Console.WriteLine();

            DialClockArray DCA2;
            DCA2 = InputDialCLockArray();
            Console.WriteLine("Полученный массив: ");
            Console.WriteLine(DCA2.Show());
            DCA2 = InputDialCLockArray();
            Console.WriteLine("Полученный массив: ");
            Console.WriteLine(DCA2.Show());

            Console.WriteLine();

            Console.WriteLine("Копируем массив DCA2 как DCA3");
            DialClockArray DCA3 = new DialClockArray(DCA2);
            Console.WriteLine("Изменим первый элемент в массиве DCA2 на DialClock(7, 7)");
            DCA2[0] = new DialClock(7, 7);
            Console.WriteLine("Массив DCA2: ");
            Console.WriteLine(DCA2.Show());
            Console.WriteLine("Массив DCA3: ");
            Console.WriteLine(DCA3.Show());

            Console.WriteLine();

            Console.WriteLine($"Обращаемся к первому элементу массива (DCA3[0]): {DCA3[0].Show()}");

            Console.WriteLine();

            Console.WriteLine($"Меняем первый элемент на DialClock(15, 15)");
            DCA3[0] = new DialClock(15, 15);
            Console.WriteLine("Изменный массив DCA3: ");
            Console.WriteLine(DCA3.Show());

            Console.WriteLine();

            Console.Write("Попытка обращению к несуществующему 100-ому элементу (DCA3[100]): ");
            try
            {
                DCA3[100].Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            Console.Write("Попытка замены несуществующего 100-го элемента (DCA3[100] = new DialClock(15, 15)): ");
            try
            {
                DCA3[100] = new DialClock(15, 15);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            DialClockArray DCA4 = InputDialCLockArray();
            Console.WriteLine("Массив: ");
            Console.WriteLine(DCA4.Show());

            Console.WriteLine($"Объект массива с максимальным углом между стрелками: {MaxCorner(DCA4).Show()}"); ;

            Console.WriteLine();

            Console.WriteLine($"Количество объектов типа DialClock: {DialClockArray.GetCountObject()}");
            Console.WriteLine($"Количество коллекций типа DialClockArray: {DialClockArray.GetCountCollection()}");
        }
    }
}
