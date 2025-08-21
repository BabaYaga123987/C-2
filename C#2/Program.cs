using System.ComponentModel.Design;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер пальца руки");
            int fingerNumber = int.Parse(Console.ReadLine());

            if (fingerNumber == 1)
            {
                Console.WriteLine("Большой палец");
            }
            else if (fingerNumber == 2)
            {
                Console.WriteLine("Указательный палец");
            }
            else if (fingerNumber == 3)
            {
                Console.WriteLine("Средний палец");
            }
            else if (fingerNumber == 4)
            {
                Console.WriteLine("Безымянный палец");
            }
            else if (fingerNumber == 5)
            {
                Console.WriteLine("Мизинец");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректный номер пальца (от 1 до 5)");
            }


            Console.WriteLine("Введите первое целое однозначное число");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое однозначное число");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат умножения двух чисел?");
            int answer = int.Parse(Console.ReadLine());

            if (answer == firstNumber * secondNumber)
            {
                Console.WriteLine("Верно!");
            }
            else
            {
                int correctanswer = firstNumber * secondNumber;
                Console.WriteLine($"Неверно, ответ равен: {correctanswer}");
            }
           
        }
    }
}
