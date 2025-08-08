namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int product = a * b;
            int difference = a - b;
            double arithmetic = (double)(a + b) / 2;

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Разность: {difference}");
            Console.WriteLine($"Среднее арифметическое: {arithmetic}");

            Console.Write("Введите четырехзначное целое число: ");
            int number = int.Parse(Console.ReadLine());
        

        }
    }
}
