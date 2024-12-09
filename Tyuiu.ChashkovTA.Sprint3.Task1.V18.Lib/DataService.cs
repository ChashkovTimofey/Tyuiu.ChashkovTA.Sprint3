using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChashkovTA.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int i = 1;
            while (i <= 15)
            {
                sum += Math.Sin(i) * Math.Pow(1.0 / 4.0, 2);
                i++;
            }
            return sum;
        }
    }
}
