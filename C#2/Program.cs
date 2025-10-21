using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace C_2
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Encryption Console Program ===");
            Console.WriteLine("1. Polybius Cipher");
            Console.WriteLine("2. Vigenère Cipher");
            Console.WriteLine("3. Caesar Cipher");
            Console.Write("\nChoose a cipher (1–3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- Running Polybius Cipher ---\n");
                    PolybiusProgram.Run(args);
                    break;

                case "2":
                    Console.WriteLine("\n--- Running Vigenère Cipher ---\n");
                    VigenereProgram.Run(args);
                    break;

                case "3":
                    Console.WriteLine("\n--- Running Caesar Cipher ---\n");
                    CaesarProgram.Run(args);
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Exiting the program.");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    internal class PolybiusProgram
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Enter the text to encrypt :");
            string text = Console.ReadLine();
            var onlyLettersBuilder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToUpper(text[i]);
                if (c >= 'A' && c <= 'Z')
                {
                    onlyLettersBuilder.Append(c);
                }
            }
            string onlyLetters = onlyLettersBuilder.ToString();

            Dictionary<char, string> map = new Dictionary<char, string>()
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
                if (map.ContainsKey(c))
                {
                    encryptedBuilder.Append(map[c]);
                }
            }
            string encrypted = encryptedBuilder.ToString();
            Console.WriteLine($"Encrypted text: \n{encrypted}");

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

                if (!map2[value].Contains(key))
                {
                    map2[value].Add(key);
                }
            }

            List<string> variants = new List<string>();
            variants.Add("");

            for (int i = 0; i < encrypted.Length; i += 2)
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

            Console.WriteLine("All possible decryptions:");
            for (int i = 0; i < variants.Count; i++)
            {
                Console.WriteLine(variants[i]);
            }
        }
    }
    internal class VigenereProgram
    {
        static readonly Dictionary<char, int> AlphabetToIndex = new Dictionary<char, int>()
        {
            {'A',0},{'B',1},{'C',2},{'D',3},{'E',4},
            {'F',5},{'G',6},{'H',7},{'I',8},{'J',9},
            {'K',10},{'L',11},{'M',12},{'N',13},{'O',14},
            {'P',15},{'Q',16},{'R',17},{'S',18},{'T',19},
            {'U',20},{'V',21},{'W',22},{'X',23},{'Y',24},
            {'Z',25}
        };

        static readonly Dictionary<int, char> IndexToAlphabet = new Dictionary<int, char>()
        {
            {0,'A'},{1,'B'},{2,'C'},{3,'D'},{4,'E'},
            {5,'F'},{6,'G'},{7,'H'},{8,'I'},{9,'J'},
            {10,'K'},{11,'L'},{12,'M'},{13,'N'},{14,'O'},
            {15,'P'},{16,'Q'},{17,'R'},{18,'S'},{19,'T'},
            {20,'U'},{21,'V'},{22,'W'},{23,'X'},{24,'Y'},
            {25,'Z'}
        };

        public static void Run(string[] args)
        {
            Console.WriteLine("Enter the text to encode:");
            string message = Console.ReadLine();
            Console.WriteLine("Create a keyword:");
            string keyword;
            while (true)
            {
                keyword = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(keyword) && keyword.All(char.IsLetter))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter letters only (A-Z, a-z), and not an empty string:");
            }

            string encodedMessage = Encode(message, keyword);
            Decode(encodedMessage, keyword);
        }

        static string Encode(string message, string keyword)
        {
            string filteredMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = char.ToUpper(message[i]);
                if (c >= 'A' && c <= 'Z')
                {
                    filteredMessage += c;
                }
            }

            keyword = keyword.ToUpper();

            int[] messageAlphabetValue = new int[filteredMessage.Length];
            int[] keywordAlphabetValue = new int[keyword.Length];
            int[] messageAndKeywordAlphabetValue = new int[filteredMessage.Length];
            char[] encodedMessageChar = new char[filteredMessage.Length];

            for (int i = 0; i < keyword.Length; i++)
            {
                keywordAlphabetValue[i] = AlphabetToIndex[keyword[i]];
            }

            for (int i = 0; i < filteredMessage.Length; i++)
            {
                messageAlphabetValue[i] = AlphabetToIndex[filteredMessage[i]];
                int sum = messageAlphabetValue[i] + keywordAlphabetValue[i % keyword.Length];
                messageAndKeywordAlphabetValue[i] = sum % 26;
                encodedMessageChar[i] = IndexToAlphabet[messageAndKeywordAlphabetValue[i]];
            }

            string encodedMessage = new string(encodedMessageChar);

            Console.WriteLine($"Encoded message:\n{encodedMessage}");
            return encodedMessage;
        }

        static void Decode(string encodedMessage, string keyword)
        {
            keyword = keyword.ToUpper();
            encodedMessage = encodedMessage.ToUpper();

            int[] encodedMessageCharValues = new int[encodedMessage.Length];
            int[] keywordAlphabetValues = new int[keyword.Length];
            int[] decodedValues = new int[encodedMessage.Length];
            char[] decodedMessageChar = new char[encodedMessage.Length];

            for (int i = 0; i < keyword.Length; i++)
            {
                keywordAlphabetValues[i] = AlphabetToIndex[keyword[i]];
            }

            for (int i = 0; i < encodedMessage.Length; i++)
            {
                encodedMessageCharValues[i] = AlphabetToIndex[encodedMessage[i]];
                decodedValues[i] = (encodedMessageCharValues[i] - keywordAlphabetValues[i % keyword.Length] + 26) % 26;
                decodedMessageChar[i] = IndexToAlphabet[decodedValues[i]];
            }

            string decodedMessage = new string(decodedMessageChar);
            Console.WriteLine($"Decoded message:\n{decodedMessage}");
        }
    }
    internal class CaesarProgram
    {
        static readonly Dictionary<char, int> AlphabetToIndex2 = new Dictionary<char, int>()
        {
            {'A',0},{'B',1},{'C',2},{'D',3},{'E',4},
            {'F',5},{'G',6},{'H',7},{'I',8},{'J',9},
            {'K',10},{'L',11},{'M',12},{'N',13},{'O',14},
            {'P',15},{'Q',16},{'R',17},{'S',18},{'T',19},
            {'U',20},{'V',21},{'W',22},{'X',23},{'Y',24},
            {'Z',25}
        };

        static readonly Dictionary<int, char> IndexToAlphabet2 = new Dictionary<int, char>()
        {
            {0,'A'},{1,'B'},{2,'C'},{3,'D'},{4,'E'},
            {5,'F'},{6,'G'},{7,'H'},{8,'I'},{9,'J'},
            {10,'K'},{11,'L'},{12,'M'},{13,'N'},{14,'O'},
            {15,'P'},{16,'Q'},{17,'R'},{18,'S'},{19,'T'},
            {20,'U'},{21,'V'},{22,'W'},{23,'X'},{24,'Y'},
            {25,'Z'}
        };

        public static void Run(string[] args)
        {
            Console.WriteLine("Enter the text to encrypt:");
            string text = Console.ReadLine();
            Console.WriteLine("Create a code (from 1 to 25):");
            int code;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out code) || code < 1 || code > 25)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 25 to encrypt your message:");
                }
                else
                {
                    break;
                }
            }
            string encryptedText = Encode(text, code);
            Decode(encryptedText, code);
        }

        static string Encode(string text, int code)
        {
            string filteredtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToUpper(text[i]);
                if (c >= 'A' && c <= 'Z')
                {
                    filteredtext += c;
                }
            }
            char[] textArray = filteredtext.ToCharArray();
            string encryptedText = "";
            for (int i = 0; i < textArray.Length; i++)
            {
                int index = AlphabetToIndex2[textArray[i]];
                int newIndex = (index + code) % 26;
                char newChar = IndexToAlphabet2[newIndex];
                encryptedText += newChar;
            }
            Console.WriteLine("Encrypted text: " + encryptedText);
            return encryptedText;
        }

        static void Decode(string encryptedText, int code)
        {
            char[] textArray = encryptedText.ToCharArray();
            string decryptedText = "";
            for (int i = 0; i < textArray.Length; i++)
            {
                int index = AlphabetToIndex2[textArray[i]];
                int newIndex = (index - code + 26) % 26;
                char newChar = IndexToAlphabet2[newIndex];
                decryptedText += newChar;
            }
            Console.WriteLine("Decrypted text:" + decryptedText);
        }
    }

}





