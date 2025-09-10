using System.Reflection.Metadata.Ecma335;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            
            for (int number = 10; number < 21; number++)
            {
                int square;
                square = number * number;
                Console.WriteLine(square);
            }




            // task 2
            Console.WriteLine("Введите число n (n > 1):");
            while (true)
            {
                int n;
                string input = Console.ReadLine();
                if (!int.TryParse(input, out n) || n <= 1)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число n (n > 1).");
                    continue;
                }
                if (n > 1)
                {
                    ulong sum = 0;
                    for (uint i = 1; i <= n; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Сумма чисел от 1 до {n} равна: {sum}");
                    break;
                }
            }


            // task 3
            for (int number2 = 20; number2 < 50; number2++)
            {
                if (number2 % 3 == 0 && number2 % 5 != 0)
                {
                    Console.WriteLine(number2);
                }
            }


            // task 4
            Console.WriteLine("Введите целое число:");

            
            while (true)
            {
                if (!long.TryParse(Console.ReadLine(), out long number3))
                {
                    Console.WriteLine("Ошибка: введите корректное целое число");
                    continue;
                }
                else
                {
                    do
                    {
                        long dividednumber;
                        dividednumber = Math.Abs(number3 % 10);
                        Console.WriteLine(dividednumber);
                        number3 = number3 / 10;

                    } while (number3 != 0);
                    break;
                }

            }


            
        }
    }
}
