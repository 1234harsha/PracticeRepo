using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the word");
            string word = Console.ReadLine();
            string reversedWord = ReverseWord(word);

            Console.WriteLine($"Reversed word: {reversedWord}");

            Console.ReadLine(); // Pause to see the result
        }

        static string ReverseWord(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
