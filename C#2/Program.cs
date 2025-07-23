namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender (m/f)");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter your favorite letter");
            char letter = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your city");
            string city = Console.ReadLine();
            Console.WriteLine($"Enter your name: {name}");
            Console.WriteLine($"Enter your age: {age}");
            Console.WriteLine($"Enter your height: {height}");
            Console.WriteLine($"Enter your gender (m/f): {gender}");
            Console.WriteLine($"Enter your favorite letter: {letter}");
            Console.WriteLine($"Enter your city: {city}");
        }
    }
}
