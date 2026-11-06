using Tyuiu.TsarevMA.Sprint3.Task6.V9.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            Tyuiu.TsarevMA.Sprint3.Task6.V9.Lib.DataService ds = new Tyuiu.TsarevMA.Sprint3.Task6.V9.Lib.DataService();

            int startValue = 19;
            int stopValue = 30;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            bool wait = true;
            Assert.AreEqual(wait, res != 0);
        }
    }
}
