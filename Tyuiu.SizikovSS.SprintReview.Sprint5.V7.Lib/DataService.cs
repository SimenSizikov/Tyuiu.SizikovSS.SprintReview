using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.SizikovSS.SprintReview.Sprint5.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЮЬЭЮЯ";//Набор символов для проверки

            string content = File.ReadAllText(path, Encoding.UTF8);
            string outPath = Path.Combine(@"C:\Users\simen\source\repos\Tyuiu.SizikovSS.SprintReview\OutPutDataFileTask7V7.txt");

            foreach (char c in alphabet)
            {
                content = content.Replace(Convert.ToString(c), "");
            }
            File.WriteAllText(outPath, content, Encoding.UTF8);
            return outPath;
        }
    }
}
