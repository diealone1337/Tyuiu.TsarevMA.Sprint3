using Tyuiu.TsarevMA.Sprint3.Task2.V8.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            // Проверка выполнения расчета
            bool wait = true;
            Assert.AreEqual(wait, res != 0);
        }
    }
}
