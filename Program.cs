/*
 * Author: Logan King
 * Course: Comp003A
 * Purpouse: To show our ability to use lists and arrays.
 */

using System.Xml.Serialization;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void sectionSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));

        }

        static void sectionSeparator(string fake)
        {
            sectionSeparator();
            Console.WriteLine(fake);
            sectionSeparator();
        }

        static void characterCounter(char characterInput, string word)
        {
            int characterINT = Convert.ToInt32(characterInput);
            int wordINT = Convert.ToInt32(word);
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();

            foreach (char characterInt in word)
            {
                count++;
            }

            /// Console.WriteLine($"There are {count} {characterInput} in MiSsIsSiPpI"); save for later
        }

       static void IsPalindrome(string word, string reversedWord)
        { 
            word.ToLower();

            if (reversedWord == word)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }




    }
}