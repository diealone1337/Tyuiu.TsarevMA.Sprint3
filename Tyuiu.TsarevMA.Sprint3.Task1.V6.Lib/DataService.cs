using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TsarevMA.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {

        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;

            while (k <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow(value, k) + 1) * Math.Sin(k);
                k++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
