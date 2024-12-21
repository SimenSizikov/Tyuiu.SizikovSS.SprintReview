using Tyuiu.SizikovSS.SprintReview.Sprint5.V7.Lib;
using System.IO;
using System.Text;


namespace Tyuiu.SizikovSS.SprintReview.Sprint5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #5 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Спринт ревью.                                                     *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все заглавные *");
            Console.WriteLine("* русские символы из файла. Полученный результат сохранить в файл.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\Users\simen\source\repos\Tyuiu.SizikovSS.SprintReview\InPutDataFileTask7V7.txt");

            Console.WriteLine("* Путь файла: " + path);
            Console.WriteLine("* Начальная строка:\n* " + File.ReadAllText(path, Encoding.UTF8));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string OutPut = ds.LoadDataAndSave(path);
            Console.WriteLine("* Преобразованная строка:\n* " + File.ReadAllText(OutPut, Encoding.UTF8));

            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}
