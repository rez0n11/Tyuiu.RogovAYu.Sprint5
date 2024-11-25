using Tyuiu.RogovAYu.Sprint5.Task1.V27.Lib;
using System;

namespace Tyuiu.RogovAYu.Sprint5.Task1.V27
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:5.1.v27| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:          *\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = [-5,5]                                                               *\n");

            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.SaveToFileTextData(-5,5);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* ФАЙЛ СОЗДАН: {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
