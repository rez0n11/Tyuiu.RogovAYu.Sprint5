using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RogovAYu.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int i = 0, k = 0;
            string[] a = File.ReadAllText(path).Split(' ');
            foreach (string s in a)
            {
                if (int.TryParse(s,out k)&& s.Length==5)
                {
                   i++;
                }           
            }
            return i;
        }
    }
}
