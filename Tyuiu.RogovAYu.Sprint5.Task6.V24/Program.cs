using Tyuiu.RogovAYu.Sprint5.Task6.V24.Lib;
using System;

namespace Tyuiu.RogovAYu.Sprint5.Task6.V24
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result;

            Console.Title = "Task:5.6.v24| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:          *\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* "+ Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V24.txt"));
            

            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.LoadFromDataFile(Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V24.txt"));
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
