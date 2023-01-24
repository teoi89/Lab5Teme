using System;

namespace Lab5Teme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            Ex4v1();
            //Ex4v2();
            //Ex5();
            //Ex6();
        }
        static void Ex1()
        {
            /* Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
            siruri de caractere fiind citite de la tastatura */
            Console.WriteLine("Introduceti un cuvant sau o propozitie:");
            Console.WriteLine(ReturnSubstring(Console.ReadLine()));
        }
        static void Ex2()
        {
            /* Scrieti un program care sa verifice daca un sir de caractere citit de la
            tastatura este sau nu palindrom. */
            Console.WriteLine("Introduceti un cuvant sau o propozitie:");
            Console.WriteLine(GetReversedString(Console.ReadLine()));
        }
        static void Ex3()
        {
            /* Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
            de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la
            tastatura */
            //Console.WriteLine(GetAppearancesOfAChar(Console.ReadLine()));
        }
        static void Ex4v1()
        {
            /* Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
            de la tastatura, ignorand caseing-ul literelor. */
            string str = Console.ReadLine();
            int numberOfAppearances = GetNumberOfAppearancesForACharacter(str);
            string character = (GetCharacterWithMostAppearances(str));
            Console.WriteLine($"The number with most appearances is: {character} and it appear for {numberOfAppearances} times");
        }
        static void Ex4v2()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            var (maxChar, maxCount) = FindMaxOccurrence(input);
            Console.WriteLine("The character with the most occurrences is '{0}' with {1} occurrences.", maxChar, maxCount);
        }
        static void Ex5()
        {
            /* Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
            sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici. */
        }
        static void Ex6()
        {
            
        }
        static string ReturnSubstring(string word)
        {
            Console.WriteLine("Introduceti pozitia de la care sa fie afisat substringul");
            int stringPosition = int.Parse(Console.ReadLine());
            if (stringPosition < word.Length)
            {
                return (word.Substring(stringPosition));
            }
            else
            {
                return ("Lungimea stringului e mai mica decat numarul introdus");
            }
        }
        public static bool GetReversedString(string wordToReverse)
        {
            int i = 0;
            int j = wordToReverse.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char charFromStart = wordToReverse[i];
                char charFromEnd = wordToReverse[j];
                if (char.ToLower(charFromStart) != (char.ToLower(charFromEnd)))
                {
                    return false;
                }
                i++;
                j--;
            }

        }
        static string GetTheCharacterWithMostAppearances(string sentence)
        {
            int[] charCount = new int[256];
            int maxCount = 0;
            char maxChar = ' ';

            foreach (char c in sentence)
            {
                charCount[c]++;
                if (charCount[c] > maxCount)
                {
                    maxCount = charCount[c];
                    maxChar = c;
                }
            }
            return maxChar.ToString();
        }
        static int GetNumberOfAppearancesForACharacter(string sentence)
        {
            int[] charCount = new int[256];
            int maxCount = 0;
            char maxChar = ' ';

            foreach (char c in sentence)
            {
                charCount[c]++;
                if (charCount[c] > maxCount)
                {
                    maxCount = charCount[c];
                    maxChar = c;
                }
            }
            return maxCount;
        }
        static Tuple<char, int> FindMaxOccurrence(string input)
        {
            int[] charCount = new int[256];

            // Count occurrences of each character
            foreach (char c in input)
            {
                charCount[c]++;
            }

            int maxCount = 0;
            char maxChar = ' ';

            // Find character with the most occurrences
            for (int i = 0; i < charCount.Length; i++)
            {
                if (charCount[i] > maxCount)
                {
                    maxCount = charCount[i];
                    maxChar = (char)i;
                }
            }
            return Tuple.Create(maxChar, maxCount);
        }
        static string GetCharacterWithMostAppearances(string str)
        {

            return null;
        }
        static string GetNormalizedString(string str)
        {

            return null;
        }
        
    }
}
