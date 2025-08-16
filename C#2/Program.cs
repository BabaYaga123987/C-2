namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1 = (3 + 5 * (6 + 3) - 8 * 3 + 1) / (21 + 50 /(double) (3 + 4 * (1 + 2)));
            double result2 = ((0.25 - 0.12) * 0.81 + 0.132 - 2.7 / 3.1) / ((double)3 / 7 + 2.97 * (8.05 - 8.1 * 6.07));
            Console.WriteLine("Результаты вычислений:");
            Console.WriteLine(result1);
            Console.WriteLine(result2);


            Console.Write("Введите первое целое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье целое число:");
            int c = int.Parse(Console.ReadLine());

            double result11 = a + b - c * (3 * a * b + Math.Pow(a, 2)) / (b * c) - Math.Pow(c + (double)(a * b) / c, 2);

            double result21 = Math.Pow(a * b + 7 * c, 3) - (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
            double result22 = result21 / (b - a * c - a * (b + c)); /* Второй пример был разбит на 2 переменные 
            в целях удобства, поскольку весь пример не вмещался в одну строку*/

            Console.WriteLine($"Результат первого примера равен: {result11}");
            Console.WriteLine($"Результат второго примера равен: {result22}");
        }
    }
}
