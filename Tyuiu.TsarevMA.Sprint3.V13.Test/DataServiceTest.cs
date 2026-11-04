using Tyuiu.TsarevMA.Sprint3.V13.Lib;
namespace Tyuiu.TsarevMA.Sprint3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            bool wait = true;
            Assert.AreEqual(wait, res != 0);
        }
    }
}
