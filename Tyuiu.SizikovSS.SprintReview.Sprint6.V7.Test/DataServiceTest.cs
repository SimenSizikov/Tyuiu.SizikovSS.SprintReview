using Tyuiu.SizikovSS.SprintReview.Sprint6.V7.Lib;

namespace Tyuiu.SizikovSS.SprintReview.Sprint6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidGenMatrix()
        {
            // Аргументы для создания матрицы
            int N = 4;
            int M = 6;
            int n1 = -10;
            int n2 = 20;

            int[,] matrix = ds.GenMatrix(N, M, n1, n2);

            bool exist = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (matrix[i, j] != null) exist = true;
                    else exist = false;
                    Assert.AreEqual(true, exist);
                }
            }

        }
    

        [TestMethod]
        public void ValidGetMatrix()
        {
            int c = 3, k = 0, l = 1;

            int[,] array = {
                { 1, -2, 3, -6, 1},
                { -4, 0, -6, 2, -7},
                { 7, -8, 9, -1, 1},
                { -1, 7, -3, 8, -5},
                { 1, -2, 3, -4, 2}};

            int res = ds.GetMatrix(array, c, k, l);

            Assert.AreEqual(2, res);
        }
    }
}
