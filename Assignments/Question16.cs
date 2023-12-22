using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word :");
            string word = Console.ReadLine();
            int Length = word.Length;
            Console.WriteLine($"length of the word {word} is :{Length}");
        }
    }
}
