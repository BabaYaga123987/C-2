using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число:");
            while (true)
            {   
                int amount = 0;
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number) && number >= 1000 && number <= 9999)
                {
                    int number1000 = number / 1000;
                    int number100 = (number / 100) % 10;
                    int number10 = (number / 10) % 10;
                    int number1 = number % 10;
                    if (number1000 % 2 == 0)
                    {
                        amount++;
                    }
                    if (number100 % 2 == 0)
                    {
                        amount++;
                    }
                    if (number10 % 2 == 0)
                    {
                        amount++;
                    }
                    if (number1 % 2 == 0)
                    {
                        amount++;
                    }
                    Console.WriteLine($"Количество четных цифр: {amount}");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите четырехзначное число:");
                    continue;
                }
           }



                int firstOdd;
                int secondOdd;
                int sum;
                while (true)
                {
                    Console.WriteLine("Введите первое нечетное целое число:");
                    if (int.TryParse(Console.ReadLine(), out firstOdd) && firstOdd % 2 != 0)
                    {
                        firstOdd = firstOdd * firstOdd;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите первое нечетное целое число.");
                        continue;
                    }
                }


                while (true)
                {
                    Console.WriteLine("Введите второе нечетное целое число:");
                    if (int.TryParse(Console.ReadLine(), out secondOdd) && secondOdd % 2 != 0)
                    {
                        secondOdd = secondOdd * secondOdd;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите второе нечетное целое число.");
                        continue;
                    }
                } 

                sum = firstOdd + secondOdd;
                Console.WriteLine($"Сумма квадратов двух нечетных чисел: {sum}");







            int attempts = 0;
            Console.WriteLine("Введите пароль:"); // Пароль: 12345
            while (true)
            {
                if (Console.ReadLine() == "12345")
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    attempts++;
                    if (attempts != 5)
                    {
                        Console.WriteLine("Пароль неверный. Изначально вы можете повторить ввод до 5 раз.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        } 
        }
    }

