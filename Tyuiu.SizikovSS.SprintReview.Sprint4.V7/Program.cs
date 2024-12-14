using Tyuiu.SizikovSS.SprintReview.Sprint4.V7.Lib;

namespace Tyuiu.SizikovSS.SprintReview.Sprint4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #2 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Спринт-ревью                                                      *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"31415926\". Преобразуйте            *");
            Console.WriteLine("* ее в матрицу 5 на 3 и подсчитайте произведение нечетных чисел.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "31415926";
            int n = 5, m = 3;

            Console.WriteLine("Строка: \"31415926\"");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Массив:");

            int[,] matrix = new int[n, m];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(str[count].ToString());
                    count++;
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nПроизведение нечётных чисел в массиве: " + ds.Calculate(n, m, str));
            Console.ReadLine();
        }
    }
}
