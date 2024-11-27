using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RogovAYu.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            double r = 0; int i = 0;
            using StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (Convert.ToDouble(line.Replace('.',','))%5==0)
                {
                    r += Convert.ToDouble(line.Replace('.', ','));
                    i++;
                }
            }
            return r/i;
        }
    }
}
