using Tyuiu.TsarevMA.Sprint3.Task7.V7.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            Tyuiu.TsarevMA.Sprint3.Task7.V7.Lib.DataService ds = new Tyuiu.TsarevMA.Sprint3.Task7.V7.Lib.DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;
            double[] wait = new double[len];

            Assert.AreEqual(len, ds.GetMassFunction(startValue, stopValue).Length);
        }
    }
}
