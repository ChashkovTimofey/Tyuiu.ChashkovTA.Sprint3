using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChashkovTA.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1;
            for (int k = 1; k <= 6; k++)
            {
                product *= Math.Pow((2 / (Math.Cos(k) + 0.5)), k);
            }
            return product;
        }
    }
}
