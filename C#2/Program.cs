namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("Год высокосный");
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Год высокосный");
            }
            else
            {
                Console.WriteLine("Год не высокосный");
            }


            Console.WriteLine("Введите первое целое число");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье целое число");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("Пожалуйста, вводите только позитивные или отрицательные числа (кроме 0)");
            }
            else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                Console.WriteLine("Количество положительных чисел: 3");
                Console.WriteLine("Количество отрицательных чисел: 0");
            }
            else if ((firstNumber > 0 && secondNumber > 0) || (secondNumber > 0 && thirdNumber > 0) 
                || (firstNumber > 0 && thirdNumber > 0))
            {
                Console.WriteLine("Количество положительных чисел: 2");
                Console.WriteLine("Количество отрицательных чисел: 1");
            }
            else if (firstNumber > 0 || secondNumber > 0 || thirdNumber > 0)
            {
                Console.WriteLine("Количество положительных чисел: 1");
                Console.WriteLine("Количество отрицательных чисел: 2");
            }
            else
            {
                Console.WriteLine("Количество положительных чисел: 0");
                Console.WriteLine("Количество отрицательных чисел: 3");
            }
        }
    }
}
