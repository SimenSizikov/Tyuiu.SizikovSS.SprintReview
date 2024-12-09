using Tyuiu.SizikovSS.SprintReview.Sprint3.V7.Lib;

namespace Tyuiu.SizikovSS.SprintReview.Sprint3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #2 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Спринт-ревью                                                      *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая выводит таблицу значений функции:     *");
            Console.WriteLine("* произвести табулирование в диапазоне [-5; 5] с шагом 1.                 *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Произвести проверку деления на ноль. Значения занести в массив.         *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start, stop;
            do
            {
                Console.Write("Введите начальное значение: ");
                start = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите конечное значение: ");
                stop = Convert.ToInt32(Console.ReadLine());

                if (start > stop) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
            } while (start > stop);

            int count = 0;
            for (int i = start; i <= stop; i++) count++;

            double[] mass = new double[count];
            mass = ds.GetMassFunction(start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int temp = 0;
            for (int i = start; i <= stop; i++)
            {
                Console.WriteLine("* X = " + i + " \tF(X) = " + mass[temp]);
                temp++;
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadLine();

        }
    }
}
