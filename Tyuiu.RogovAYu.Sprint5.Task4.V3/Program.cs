using Tyuiu.RogovAYu.Sprint5.Task4.V3.Lib;
using System;

namespace Tyuiu.RogovAYu.Sprint5.Task4.V3
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:5.4.v3| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:  f(x) = (sinx+4)/x-1.25x                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            string x = File.ReadAllText(Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V3.txt"));
            Console.Write(x + "\n");

            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.LoadFromDataFile(Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V3.txt"));
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* f({x}) = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
