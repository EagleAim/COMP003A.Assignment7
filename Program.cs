﻿/*
 * Author: Logan King
 * Course: Comp003A
 * Purpouse: To show our ability to use lists and arrays.
 */

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

            Console.WriteLine($"There are {count} {characterInput} in {Word}");



            sectionSeparator();
            Console.WriteLine("IsPalindrome Section");
            sectionSeparator();

            Console.WriteLine("\t Please input a word");
            var Word1 = Console.ReadLine();

            IsPalindrome(Word1);

            Console.WriteLine($"Is the {word1} palindrome: {reversedWord}");

            sectionSeparator();
            Console.WriteLine("Add Section");
            sectionSeparator();

            List<string> names = new List<string>();
            char userInput = default;

            Console.WriteLine("Press any key to add more or (e) to exit.");
            var userInput1 = Console.ReadLine();

            do while (userInput1 != 'n')
                {
                    Console.WriteLine("Press any key to add more or (e) to exit.");

                    if (userInput1 == 'e')
                    {
                        break;
                    }
                }



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
            int wordINT = Convert.ToInt32(word);
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

            var reversedWord;

            if (reversedWord == word)
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