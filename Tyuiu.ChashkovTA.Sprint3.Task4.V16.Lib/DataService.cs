using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChashkovTA.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1;
            for (double x = startValue; x <= stopValue; x += 0.1) 
            {
                if (x == 0) continue; 
                double y = CalculateY(x);
                product *= y;
            }
            return product;
        }

        public static double CalculateY(double x)
        {
            return (Math.Cos(x) + x) / x + 0.25;
        }
    }
    
}
