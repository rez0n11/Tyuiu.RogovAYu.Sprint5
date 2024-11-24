
using System;
using Tyuiu.RogovAYu.Sprint5.Task0.V15.Lib;

namespace Tyuiu.RogovAYu.Sprint.Task.V
{
    public class Program
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:5.0.v15| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:          *\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = 3                                                                ");
            
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.SaveToFileTextData(3);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Файл создан: "+result);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
