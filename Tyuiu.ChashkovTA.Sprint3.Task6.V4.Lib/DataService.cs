using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChashkovTA.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                totalCount += CountDivisorsGreaterThanThreshold(i, 9);
            }
            return totalCount;
        }

        public static int CountDivisorsGreaterThanThreshold(int number, int threshold)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0 && i > threshold)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
