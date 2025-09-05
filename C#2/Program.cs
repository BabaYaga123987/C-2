using System.Reflection.Metadata.Ecma335;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int square;
            for (int number = 10; number < 21; number++)
            {
                square = number * number;
                Console.WriteLine(square);
            }





            int n = 0;
            long sum = 0;

            Console.WriteLine("Введите число n:");

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                    continue;
                }
            }
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Сумма чисел от 1 до {n} равна: {sum}");
            }
            else if (n < 0)
            {
                for (int i = 1; i >= n; i--)
                {
                    sum += i;
                }
                Console.WriteLine($"Сумма чисел от 1 до {n} равна: {sum}");
            }
            else
            {
                Console.WriteLine("Сумма чисел от 1 до 0 равна: 0");
            }




            for (int number2 = 20; ; number2++)
            {
                if (number2 == 50)
                {
                    break;
                }
                else if (number2 % 3 == 0 && number2 % 5 != 0)
                {
                    Console.WriteLine(number2);
                }
            }



            Console.WriteLine("Введите целое число:");


            while (true)
            { 
                if (!long.TryParse(Console.ReadLine(), out long number3))
            {
                Console.WriteLine("Ошибка: введите корректное целое число");
                    continue;
            }
                long dividednumber;
                do
                {
                    dividednumber = Math.Abs(number3 % 10);
                    Console.WriteLine(dividednumber);
                    number3 = number3 / 10;

                } while (number3 != 0);

        }

        }
    }
}
