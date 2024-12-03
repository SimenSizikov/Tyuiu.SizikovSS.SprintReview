using Tyuiu.SizikovSS.SprintReview.Sprint2.V7.Lib;

namespace Tyuiu.SizikovSS.SprintReview.Sprint2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            double x = 0, y = 1;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
