using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SizikovSS.SprintReview.Sprint3.V7.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++) count++;// 11

            double[] mass = new double[count];// массив на 11 ячеек
            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -2)
                {
                    mass[k] = 0;
                }
                else
                {
                    mass[k] = Math.Round((Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x), 2);
                }
                k++;
            }
            return mass;
        }
    }
}
