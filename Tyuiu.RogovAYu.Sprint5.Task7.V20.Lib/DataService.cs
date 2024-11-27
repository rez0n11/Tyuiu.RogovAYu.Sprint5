using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RogovAYu.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string a = File.ReadAllText(path);
            for (int i = 0; i < a.Length-1; i++)
            { 
                if (a[i] == a[i+1] && a[i] == 1089)
                {
                  a=  a.Remove(i,1);
                }
            }
            string file = Path.GetTempFileName();
            File.WriteAllText(file,a);
            return file;
        }
    }
}
