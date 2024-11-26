using Tyuiu.RogovAYu.Sprint5.Task3.V14.Lib;
using System;

namespace Tyuiu.RogovAYu.Sprint5.Task3.V14
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:5.3.v14| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:          *\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = 3");
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.SaveToFileTextData(3);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
