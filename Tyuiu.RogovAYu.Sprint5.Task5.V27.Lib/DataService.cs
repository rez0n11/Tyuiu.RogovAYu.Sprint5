using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RogovAYu.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string s = File.ReadAllText(path);
            string[] str = s.Split('\n');
            int i=0; double j=0;
            foreach (string ss in str) 
            { 
                if (Convert.ToDouble(ss.Trim()) % 5 == 0)
                {
                    i++; j += Convert.ToDouble(ss.Trim());
                }
            }
            return j / i;
        }
    }
}
