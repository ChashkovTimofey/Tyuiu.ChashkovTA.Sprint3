using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChashkovTA.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            
            StringBuilder sb = new StringBuilder();
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
