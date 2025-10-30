using System;
using System.Text;
using System.Collections.Generic;

namespace C_2
{
    internal class Menu
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Encryption Console Program ===");
            Console.WriteLine("1. Polybius Cipher");
            Console.WriteLine("2. Vigenère Cipher");
            Console.WriteLine("3. Caesar Cipher");
            Console.Write("\nChoose a cipher (1–3): ");

            int choice = ReadIntInRange(1, 3, "Invalid input. Please enter a number between 1 and 3:");

            int method = 0;
            if (choice != 2) // Vigenère handles method internally
            {
                Console.WriteLine("Choose a method: 1 - Encrypt, 2 - Decrypt");
                method = ReadIntInRange(1, 2, "Invalid input. Please enter 1 for Encrypt or 2 for Decrypt:");
            }

            if (choice == 1)
            {
                if (method == 1) PolybiusCipher.Encrypt();
                else PolybiusCipher.Decrypt();
            }
            else if (choice == 2)
            {
                VigenereCipher.Process();
            }
            else if (choice == 3)
            {
                if (method == 1) CaesarCipher.Encrypt();
                else CaesarCipher.Decrypt();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Safe integer input with range checking
        private static int ReadIntInRange(int min, int max, string errorMessage)
        {
            int value;
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out value) || value < min || value > max)
                    {
                        Console.WriteLine(errorMessage);
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return value;
        }
    }

    internal class PolybiusCipher
    {
        // Encrypt text using Polybius cipher
        public static void Encrypt()
        {
            Console.WriteLine("Enter text to encrypt:");
            string input = Console.ReadLine().ToUpper();

            Dictionary<char, string> map = new Dictionary<char, string>()
            {
                {'A',"11"}, {'B',"12"}, {'C',"13"}, {'D',"14"}, {'E',"15"},
                {'F',"21"}, {'G',"22"}, {'H',"23"}, {'I',"24"}, {'J',"24"},
                {'K',"25"}, {'L',"31"}, {'M',"32"}, {'N',"33"}, {'O',"34"},
                {'P',"35"}, {'Q',"41"}, {'R',"42"}, {'S',"43"}, {'T',"44"},
                {'U',"45"}, {'V',"51"}, {'W',"52"}, {'X',"53"}, {'Y',"54"},
                {'Z',"55"}
            };

            StringBuilder encrypted = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (map.ContainsKey(c))
                {
                    encrypted.Append(map[c]);
                }
            }

            Console.WriteLine("Encrypted text:");
            Console.WriteLine(encrypted.ToString());
        }

        // Decrypt text using Polybius cipher (J and I share the same code)
        public static void Decrypt()
        {
            string encrypted;
            while (true)
            {
                Console.WriteLine("Enter the encrypted text (digits only):");
                encrypted = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(encrypted) && int.TryParse(encrypted, out _))
                    break;
                Console.WriteLine("Invalid input. Please enter only digits.");
            }

            Dictionary<string, List<char>> map = new Dictionary<string, List<char>>()
            {
                {"11", new List<char>{'A'}}, {"12", new List<char>{'B'}}, {"13", new List<char>{'C'}},
                {"14", new List<char>{'D'}}, {"15", new List<char>{'E'}}, {"21", new List<char>{'F'}},
                {"22", new List<char>{'G'}}, {"23", new List<char>{'H'}}, {"24", new List<char>{'I','J'}},
                {"25", new List<char>{'K'}}, {"31", new List<char>{'L'}}, {"32", new List<char>{'M'}},
                {"33", new List<char>{'N'}}, {"34", new List<char>{'O'}}, {"35", new List<char>{'P'}},
                {"41", new List<char>{'Q'}}, {"42", new List<char>{'R'}}, {"43", new List<char>{'S'}},
                {"44", new List<char>{'T'}}, {"45", new List<char>{'U'}}, {"51", new List<char>{'V'}},
                {"52", new List<char>{'W'}}, {"53", new List<char>{'X'}}, {"54", new List<char>{'Y'}},
                {"55", new List<char>{'Z'}}
            };

            List<string> results = new List<string>() { "" };

            for (int i = 0; i < encrypted.Length; i += 2)
            {
                if (i + 1 < encrypted.Length)
                {
                    string pair = encrypted.Substring(i, 2);
                    if (map.ContainsKey(pair))
                    {
                        List<string> newResults = new List<string>();
                        for (int j = 0; j < results.Count; j++)
                        {
                            for (int k = 0; k < map[pair].Count; k++)
                            {
                                newResults.Add(results[j] + map[pair][k]);
                            }
                        }
                        results = newResults;
                    }
                }
            }

            Console.WriteLine("Possible decryptions:");
            foreach (string res in results)
            {
                Console.WriteLine(res);
            }
        }
    }

    internal class VigenereCipher
    {
        // Combined encryption and decryption with known keyword
        public static void Process()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            string keyword;

            while (true)
            {
                Console.WriteLine("Enter keyword (letters only):");
                keyword = Console.ReadLine().ToUpper();
                if (!string.IsNullOrWhiteSpace(keyword) && IsAllLetters(keyword)) break;
                Console.WriteLine("Invalid input. Please enter letters only (A-Z).");
            }

            Console.WriteLine("Choose: 1 - Encrypt, 2 - Decrypt");
            int choice = ReadIntInRange(1, 2, "Invalid input. Enter 1 or 2:");

            if (choice == 1)
            {
                string encrypted = Encrypt(text, keyword);
                Console.WriteLine("Encrypted text:");
                Console.WriteLine(encrypted);
            }
            else
            {
                string decrypted = Decrypt(text, keyword);
                Console.WriteLine("Decrypted text:");
                Console.WriteLine(decrypted);
            }
        }

        private static bool IsAllLetters(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsLetter(s[i])) return false;
            }
            return true;
        }

        private static int ReadIntInRange(int min, int max, string errorMessage)
        {
            int value;
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out value) || value < min || value > max)
                    {
                        Console.WriteLine(errorMessage);
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return value;
        }

        // Encrypt Vigenere
        private static string Encrypt(string text, string keyword)
        {
            text = text.ToUpper();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= 'A' && c <= 'Z')
                {
                    int shift = keyword[i % keyword.Length] - 'A';
                    char enc = (char)((c - 'A' + shift) % 26 + 'A');
                    result.Append(enc);
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        // Decrypt Vigenere
        private static string Decrypt(string text, string keyword)
        {
            text = text.ToUpper();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= 'A' && c <= 'Z')
                {
                    int shift = keyword[i % keyword.Length] - 'A';
                    char dec = (char)((c - 'A' - shift + 26) % 26 + 'A');
                    result.Append(dec);
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }

    internal class CaesarCipher
    {
        // Encrypt Caesar cipher
        public static void Encrypt()
        {
            Console.WriteLine("Enter text to encrypt:");
            string input = Console.ReadLine().ToUpper();

            int key = 0;
            while (true)
            {
                Console.WriteLine("Enter key (1-25):");
                string keyInput = Console.ReadLine();
                if (int.TryParse(keyInput, out key) && key >= 1 && key <= 25) break;
                Console.WriteLine("Invalid input. Please enter a number between 1 and 25.");
            }

            StringBuilder encrypted = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= 'A' && c <= 'Z')
                {
                    char newChar = (char)(((c - 'A' + key) % 26) + 'A');
                    encrypted.Append(newChar);
                }
                else
                {
                    encrypted.Append(c);
                }
            }

            Console.WriteLine("Encrypted text:");
            Console.WriteLine(encrypted.ToString());
        }

        // Decrypt Caesar cipher (without knowing the key)
        public static void Decrypt()
        {
            Console.WriteLine("Enter text to decrypt:");
            string encrypted = Console.ReadLine().ToUpper();

            Console.WriteLine("\nPossible decryptions:");
            for (int key = 1; key < 26; key++)
            {
                StringBuilder decrypted = new StringBuilder();
                for (int i = 0; i < encrypted.Length; i++)
                {
                    char c = encrypted[i];
                    if (c >= 'A' && c <= 'Z')
                    {
                        char newChar = (char)(((c - 'A' - key + 26) % 26) + 'A');
                        decrypted.Append(newChar);
                    }
                    else
                    {
                        decrypted.Append(c);
                    }
                }
                Console.WriteLine($"Key {key}: {decrypted}");
            }
        }
    }
}
