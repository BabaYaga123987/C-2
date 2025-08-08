namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = (3 + 5 * (6 + 3) - 8 * 3 + 1) / (21 + 50 / (3 + 4 * (1 + 2)));
            double result2 = ((0.25 - 0.12) * 0.81 + 0.132 - 2.7 / 3.1) / (3 / 7 + 2.97 * (8.05 - 8.1 * 6.07));
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
    }
}
