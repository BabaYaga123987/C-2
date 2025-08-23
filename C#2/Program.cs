using System.Diagnostics;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму выдачи (от 1 до 9999)");

            int sum = int.Parse(Console.ReadLine());

            bool mistake;
            if (sum < 1 || sum > 9999)
            {
                mistake = false;
            }
            else
            {
                mistake = true;
            }


            string thousand;
            if (sum / 1000 == 1)
            {
                thousand = "Тысяча";
            }
            else if (sum / 1000 == 2)
            {
                thousand = "Две тысячи";
            }
            else if (sum / 1000 == 3)
            {
                thousand = "Три тысячи";
            }
            else if (sum / 1000 == 4)
            {
                thousand = "Четыре тысячи";
            }
            else if (sum / 1000 == 5)
            {
                thousand = "Пять тысяч";
            }
            else if (sum / 1000 == 6)
            {
                thousand = "Шесть тысяч";
            }
            else if (sum / 1000 == 7)
            {
                thousand = "Семь тысяч";
            }
            else if (sum / 1000 == 8)
            {
                thousand = "Восемь тысяч";
            }
            else if (sum / 1000 == 9)
            {
                thousand = "Девять тысяч";
            }
            else
            {
                thousand = "";
            }


            int sum2 = sum % 1000;
            string hundred;
            if (sum2 / 100 == 1)
            {
                hundred = "сто";
            }
            else if (sum2 / 100 == 2)
            {
                hundred = "двести";
            }
            else if (sum2 / 100 == 3)
            {
                hundred = "триста";
            }
            else if (sum2 / 100 == 4)
            {
                hundred = "четыреста";
            }
            else if (sum2 / 100 == 5)
            {
                hundred = "пятьсот";
            }
            else if (sum2 / 100 == 6)
            {
                hundred = "шестьсот";
            }
            else if (sum2 / 100 == 7)
            {
                hundred = "семьсот";
            }
            else if (sum2 / 100 == 8)
            {
                hundred = "восемьсот";
            }
            else if (sum2 / 100 == 9)
            {
                hundred = "девятьсот";
            }
            else
            {
                hundred = "";
            }

            int sum3 = sum % 100;
            int sum4 = sum3 % 10;

            string ten;
            if (sum3 / 10 == 1)
            {
                if (sum4 == 0) ten = "десять";
                else if (sum4 == 1) ten = "одиннадцать";
                else if (sum4 == 2) ten = "двенадцать";
                else if (sum4 == 3) ten = "тринадцать";
                else if (sum4 == 4) ten = "четырнадцать";
                else if (sum4 == 5) ten = "пятнадцать";
                else if (sum4 == 6) ten = "шестнадцать";
                else if (sum4 == 7) ten = "семнадцать";
                else if (sum4 == 8) ten = "восемнадцать";
                else if (sum4 == 9) ten = "девятнадцать";
                else ten = "";
            }
            else
            {
                ten = sum3 / 10 == 2 ? "двадцать" :
                      sum3 / 10 == 3 ? "тридцать" :
                      sum3 / 10 == 4 ? "сорок" :
                      sum3 / 10 == 5 ? "пятьдесят" :
                      sum3 / 10 == 6 ? "шестьдесят" :
                      sum3 / 10 == 7 ? "семьдесят" :
                      sum3 / 10 == 8 ? "восемьдесят" :
                      sum3 / 10 == 9 ? "девяносто" : "";
            }

            
            string one;
            if (ten == "одиннадцать" || ten == "двенадцать" || ten == "тринадцать" ||
                ten == "четырнадцать" || ten == "пятнадцать" || ten == "шестнадцать" ||
                ten == "семнадцать" || ten == "восемнадцать" || ten == "девятнадцать")
            {
                one = "";
            }
            else
            {
                one = sum4 == 1 ? "один" : sum4 == 2 ? "два" :
                      sum4 == 3 ? "три" :
                      sum4 == 4 ? "четыре" :
                      sum4 == 5 ? "пять" :
                      sum4 == 6 ? "шесть" :
                      sum4 == 7 ? "семь" :
                      sum4 == 8 ? "восемь" :
                      sum4 == 9 ? "девять" : "";
            }


            string dollar;
            if (sum3 / 10 == 1)
            {
                dollar = "долларов";
            }
            else if (sum3 / 10 != 1 && sum4 == 1)
            {
                dollar = "доллар";
            }
            else if (sum3 / 10 != 1 && sum4 == 0)
            {
                dollar = "долларов";
            }
            else if (sum3 / 10 != 1 && sum4 > 1 && sum4 <= 4)
            {
                dollar = "доллара";
            }
            else
            {
                dollar = "долларов";
            }



            if (mistake == true)
            {
                Console.WriteLine($"Выдача: {thousand} {hundred} {ten} {one} {dollar}");
            }
            else
            {
                Console.WriteLine("Ошибка: сумма должна быть от 1 до 9999");
            }   
        }
        }
    }
