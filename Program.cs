/*
 * Author: Logan King
 * Course: Comp003A
 * Purpouse: To show our ability to use lists and arrays.
 */

using System.Diagnostics.Metrics;
using System.Xml.Serialization;
using static System.Collections.Specialized.BitVector32;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sectionSeparator();
            Console.WriteLine("CharacterCounter Section");
            sectionSeparator();

            Console.WriteLine("\t Please input a single letter");
            var Letter = Console.ReadLine();
            char charLetter = Convert.ToChar(Letter);

            Console.WriteLine("\t Please input a Word");
            var Word = Console.ReadLine();

            characterCounter(charLetter, Word);

            Console.WriteLine($"There are {Letter} {charLetter} in {Word}");



            sectionSeparator();
            Console.WriteLine("IsPalindrome Section");
            sectionSeparator();

            Console.WriteLine("\t Please input a word");
            var WordVar = Console.ReadLine();

            IsPalindrome(Word);

            Console.WriteLine($"Is the {WordVar} palindrome: {Word}");

            sectionSeparator();
            Console.WriteLine("Add Section");
            sectionSeparator();

            List<string> names = new List<string>();
            char userInput = default;

            Console.WriteLine("Press any key to add more or (e) to exit.");
            var userInput1 = Console.ReadLine();

            var Exit = "e";


            do
            {
                if (userInput1 == Exit)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("\tPress any key to add more or (e) to exit.");
                }
            } while (userInput1 != Exit);


            sectionSeparator();
            Console.WriteLine("Traversal Section");
            sectionSeparator();

            TraverseList(names);

            sectionSeparator();
            Console.WriteLine("Reverse Traversal Section");
            sectionSeparator();

            TraverseListReverse(names);
        }

        static void sectionSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));

        }

        static void characterCounter(char characterInput, string word)
        {
            int characterINT = Convert.ToInt32(characterInput);
            var wordINT = Convert.ToInt32(word);
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();

            foreach (char characterInt in word)
            {
                count++;
            }
        }

       static void IsPalindrome(string word)
        { 
            word.ToLower();

            string str = word;
            char[] reversedWord = str.ToCharArray();
            Array.Reverse(reversedWord);
            string reversedStr = new string(reversedWord);
            var wordVar = Convert.ToInt32(word);
            var reversedWordVar = Convert.ToInt32(reversedWord);

            if (reversedWordVar == wordVar)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }

        static void TraverseList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(list);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(list);
            }
        }
    }
}