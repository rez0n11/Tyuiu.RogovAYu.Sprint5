using System;

namespace Tyuiu.RogovAYu.Sprint5.Task2.V1
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:5.2.v1| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:{{ 6,9,4},{7,2,4 },{4,8,3}}     Заменить нечетные на 0          *");
            Console.WriteLine("***************************************************************************");
            int[,] n = { { 6, 9, 4 }, { 7, 2, 4 }, { 4, 8, 3 } };

            { //code
                result = ds.SaveToFileTextData(n);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  File Created: {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
