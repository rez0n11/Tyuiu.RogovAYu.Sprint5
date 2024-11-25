double start = 1, end = 2, step = 1;

string outputFile = "OutPutFileTaskl.txt";

for (double x = start; x <= end; x += step)

{
    double result = 2 * x + 3 * Math.Pow(x, 2) + 4;
    if (double.IsInfinity(result) || double.IsNaN(result))
    {

        result = 0;

    }
    result = Math.Round(result, 2);
    File.AppendAllText(outputFile, $"{result}\n");
    Console.WriteLine($"{result}");

}