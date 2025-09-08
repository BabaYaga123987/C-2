using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            /*    Console.WriteLine("Введите число целое четырехзначное число:");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int number) && input.Length == 4)
                    {
                        int amount = 0;
                        foreach (char c in input)
                        {
                            int digit = c - '0'; // перевод символа в цифру
                            if (digit % 2 == 0)
                            {
                                amount++;
                            }
                        }
                        Console.WriteLine($"Количество четных цифр: {amount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число из 4 цифр:");
                    }
                }

               /* Примечание к упражнению 1. foreach — это цикл, который перебирает все элементы какой-то коллекции 
                (массива, списка, строки и т. д.), по одному за раз. char c — это переменная, которая на каждой итерации 
                принимает один символ строки. input — указывает, что мы перебираем строку input. Цикл сам знает, сколько символов, 
                и закончит работу, когда они закончатся. 

                */

            // task 2
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






                // task 3
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


