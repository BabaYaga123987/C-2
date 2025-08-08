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
            int step1 = number % 10;
            int step10 = step1 * 1000;

            int number2 = number / 10;
            int step2 = number2 % 10;
            int step20 = step2 * 100;

            int number3 = number2 / 10;
            int step3 = number3 % 10;
            int step30 = step3 * 10;

            int step40 = number3 / 10;
            int steplast = step10 + step20 + step30 + step40;
            Console.WriteLine($"Обратное число: {steplast}");
            /* Четырехзначное число меняет порядок цифр на обратный. Сначала оно делится с остатком на 10, находя таким образом
             * последнюю цифру, которая умножается на 1000. Далее вводимое число делится на 10 нацело, так что мы получаем трехзначное 
             * число. Оно же делится на 10 с остатком, и мы получаем вторую цифру, которая переводится в сотни. Также само 
             * делится второе число на 10 нацело, и мы получаем третье число, и т. д. В конце концов эти числа суммируются, 
             * выводя обратное число (например, 1000+200+90+7=1297). */
        

        }
    }
}
