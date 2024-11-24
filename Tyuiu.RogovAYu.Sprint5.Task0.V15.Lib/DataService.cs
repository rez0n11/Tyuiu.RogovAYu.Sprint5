using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.RogovAYu.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
           string file = Path.GetTempFileName();
            string res="";
            res = Convert.ToString(Math.Round(x / (x * x * x + 2.0), 3));
           File.WriteAllText(file, res.ToString());
            return file;
        }
    }
}
