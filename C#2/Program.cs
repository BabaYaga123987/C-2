namespace C_2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text to encrypt :"); // Prompt user for input             
            string text = Console.ReadLine();
            var onlyLettersBuilder = new StringBuilder(); // Filter out non-letter characters and convert to uppercase             
            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToUpper(text[i]);
                if (c >= 'A' && c <= 'Z') // Здесь мы проверяем, является ли символ буквой при помощи таблицы ASCII ('A' = 65, 'Z' = 90)                 
                {
                    onlyLettersBuilder.Append(c); // Не буквы просто выбрасываются                 
                }
            }
            string onlyLetters = onlyLettersBuilder.ToString();

            Dictionary<char, string> map = new Dictionary<char, string>() // Polybius square mapping             
            {
                {'A',"11"}, {'B',"12"}, {'C',"13"}, {'D',"14"}, {'E',"15"},
                {'F',"21"}, {'G',"22"}, {'H',"23"}, {'I',"24"}, {'J',"24"},
                {'K',"25"}, {'L',"31"}, {'M',"32"}, {'N',"33"}, {'O',"34"},
                {'P',"35"}, {'Q',"41"}, {'R',"42"}, {'S',"43"}, {'T',"44"},
                {'U',"45"}, {'V',"51"}, {'W',"52"}, {'X',"53"}, {'Y',"54"},
                {'Z',"55"}
            };

            var encryptedBuilder = new StringBuilder();
            for (int i = 0; i < onlyLetters.Length; i++)
            {
                char c = onlyLetters[i];
                if (map.ContainsKey(c)) // Check if the character is in the map                 
                {
                    encryptedBuilder.Append(map[c]); // Append the corresponding code to the encrypted string                 
                }
            }
            string encrypted = encryptedBuilder.ToString();
            Console.WriteLine($"Encrypted text: \n{encrypted}");

            // Инверсия словаря через for             
            Dictionary<string, List<char>> map2 = new Dictionary<string, List<char>>();
            var keys = new List<char>(map.Keys);
            for (int i = 0; i < keys.Count; i++)
            {
                char key = keys[i];
                string value = map[key];
                if (!map2.ContainsKey(value))
                {
                    map2[value] = new List<char>();
                }

                
                if (!map2[value].Contains(key)) // Avoid duplicates for 'I' and 'J'
                {
                    map2[value].Add(key);
                }
            }

            
            List<string> variants = new List<string>(); // List to hold all possible decryptions
            variants.Add("");

            
            for (int i = 0; i < encrypted.Length; i += 2) // Process each pair of digits in the encrypted string
            { 
                string c = encrypted.Substring(i, 2);

                if (map2.ContainsKey(c))
                {
                    List<string> newVariants = new List<string>();

                    
                    for (int j = 0; j < variants.Count; j++)
                    {
                        string current = variants[j];

                        List<char> possible = map2[c];
                        for (int k = 0; k < possible.Count; k++)
                        {
                            char ch = possible[k];
                            newVariants.Add(current + ch);
                        }
                    }

                    variants = newVariants;
                }
            }

           
            Console.WriteLine("All possible decryptions:"); // Display all possible decryptions
            for (int i = 0; i < variants.Count; i++)
            {
                Console.WriteLine(variants[i]);
            }
        }
    }
}