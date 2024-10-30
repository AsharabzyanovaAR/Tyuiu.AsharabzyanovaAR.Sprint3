using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                for(int d = 1; d <= x; d++)
                {
                    if(x%d==0 && d > 8)
                    {
                        sum += d;
                      
                        
                    }
                    
                }
            }
            return sum;
        }
    }
}
