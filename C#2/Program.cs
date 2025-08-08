namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье целое число:");
            int c = int.Parse(Console.ReadLine());

            double result1 = (double)a + b - c * (3 * a * b + Math.Pow(a, 2) / (b * c) - Math.Pow((c + (a * b) / c), 2));

            double result21 = (double)Math.Pow(a * b + 7 * c, 3) - (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
            double result22 = result21 / (double)(b - a * c - a * (b + c)); /* Второй пример был разбит на 2 переменные 
            в целях удобства, поскольку весь пример не вмещался в одну строку*/

            Console.WriteLine($"Результат первого примера равен: {result1}");
            Console.WriteLine($"Результат второго примера равен: {result22}");
        }
    }
}
