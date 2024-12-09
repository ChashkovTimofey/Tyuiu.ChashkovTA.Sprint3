using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChashkovTA.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            int len = (stopValue - startValue) + 1;
            result = new double[11];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {

                if (x + 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;

                }
                Console.WriteLine(y);
                result[count] = y;
                count++;
            }

            return result;
        }
    }
}