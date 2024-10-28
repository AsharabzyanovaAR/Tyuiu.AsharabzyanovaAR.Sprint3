using Tyuiu.AsharabzyanovaAR.Sprint3.Task2.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = ("Спринт #3 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу,используя цикл do-while, которая вычисляет сумму ряда*");
        Console.WriteLine("* по формуле                                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 1;
        int startValue = 1;
        int stopValue = 6;

        Console.WriteLine("Переменная X=" + value);
        Console.WriteLine("Старт шага=" + startValue);
        Console.WriteLine("Конец шага=" + stopValue);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Произведение ряда=" + ds.GetMultiplySeries(value,startValue, stopValue));

        Console.ReadKey();
    }
}