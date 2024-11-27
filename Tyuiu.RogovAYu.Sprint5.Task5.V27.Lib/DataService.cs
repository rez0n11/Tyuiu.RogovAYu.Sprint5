using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RogovAYu.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                double res=0;
                int i= 0;
                string line;
                while ((line = sr.ReadLine()) != null && Convert.ToDouble(line)%5==0)
                {
                    res += Convert.ToDouble(line);
                    i++;
                }
                return (res / i);
            }

            
        }
    }
}
