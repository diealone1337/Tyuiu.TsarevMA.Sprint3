using Tyuiu.TsarevMA.Sprint3.Task5.V24.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            bool wait = true;
            Assert.AreEqual(wait, res != 0);
        }
    }
}
