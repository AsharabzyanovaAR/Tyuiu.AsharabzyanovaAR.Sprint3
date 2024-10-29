
using System.ComponentModel;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 1;
            int maxim = -100;
            int len = value.Length-1;
            for (int i=0; i < len; i++)
            {
                if (value[i] == 'z'&& value[i+1] == 'z')
                {
                    count += 1;
                    maxim = Math.Max(maxim, count);
                }
                else
                {
                    maxim = Math.Max(maxim, count);
                    count = 1;
                }

            }
            return maxim;
            
        }
    }
}
