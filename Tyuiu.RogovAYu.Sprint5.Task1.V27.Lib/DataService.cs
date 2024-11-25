using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RogovAYu.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string file = Path.GetTempFileName();
            if (File.Exists(file)) { File.Delete(file); }

            for (int i = startValue; i <= stopValue; i++)
            {
                if (i != stopValue)
                {
                    File.AppendAllText(file, Convert.ToString(Math.Round((i * 3 - 1.5) / (Math.Sin(i) - 3 + i) + 2, 2)) + "\n");
                }
                else { File.AppendAllText(file, Convert.ToString(Math.Round((i * 3 - 1.5) / (Math.Sin(i) - 3 + i) + 2, 2))); }
            }
      
            return file;
        }

    }
}