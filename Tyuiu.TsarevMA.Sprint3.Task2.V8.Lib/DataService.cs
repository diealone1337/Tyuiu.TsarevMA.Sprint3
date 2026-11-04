using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevMA.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            int k = startValue;

            do
            {
                multSeries = multSeries * Math.Pow(Math.Cos(k) + 1, 2);
                k++;
            } while (k <= stopValue);

            return Math.Round(multSeries, 3);
        }
    }
}
