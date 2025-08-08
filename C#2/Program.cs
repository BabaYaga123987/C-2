namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            double task1 = (double)(a - 1) / (b + 1);
            double task2 = (double)((b + a) * a) / 2;
            double task3 = (double)(a % b) + Math.Pow(a, b);
            /* К найденому остатку от деления числа а на b прибавляется число а в степени b, поэтому b не может 
            равняться нулю по умолчанию, а переменная а может. */
            
            Console.WriteLine($"Результат задачи 1: {task1}");
            Console.WriteLine($"Результат задачи 2: {task2}");
            Console.WriteLine($"Результат задачи 3: {task3}");


        }
    }
}
