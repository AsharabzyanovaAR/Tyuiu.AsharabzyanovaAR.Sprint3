using Tyuiu.AsharabzyanovaAR.Sprint3.Task5.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = ("Спринт #3 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу,используя вложенные циклы, которая вычисляет сумму   *");
        Console.WriteLine("* ряда по формуле                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 5;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 11;

        Console.WriteLine("Переменная X=" + x);
        Console.WriteLine("Старт шага первой суммы ряда=" + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда =" + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда=" + startValue2);
        Console.WriteLine("Конец шага второй суммы ряда =" + stopValue2);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Cумма ряда=" + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadKey();


    }
}