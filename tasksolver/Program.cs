string text = "2, 18, 4, -9, 4, 10, 18, 19, 16";
string[] strings = text.Split(",");
List<string> oddNumbers = new List<string>();
foreach (string str in strings)
{
     if (int.TryParse(str.Trim(), out int number) && number % 2 != 0)
{
        oddNumbers.Add(str);
    } }

Console.WriteLine(String.Join("\n",oddNumbers));