using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SizikovSS.SprintReview.Sprint2.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((y < 2 - Math.Pow(x, 2)) && (y > x)) || ((y < 2 - Math.Pow(x, 2)) && (y > 0))) { return true; }
            else { return false; }
        }
    }
}