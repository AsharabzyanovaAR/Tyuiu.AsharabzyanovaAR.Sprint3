﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task5.V18.Lib
{
    public class DataService : ISprint3Task5V18
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            int i,j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    sum = sum + Math.Cos(x) + (Math.Pow(j, 2) / 2);
                }
            }
            return Math.Round(sum,3);
        }
    }
}
