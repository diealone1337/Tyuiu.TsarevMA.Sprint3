using Tyuiu.TsarevMA.Sprint3.Task3.V11.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string str = "sqwreq vqwqq q";
            char chr = 'q';
            char rep = '7';

            string res = ds.ReplaceCharOnNum(str, chr, rep);
            string wait = "s7wre7 v7w77 7";

            Assert.AreEqual(wait, res);
        }
    }
}
