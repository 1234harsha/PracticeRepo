﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first word");
            string word = Console.ReadLine();
            Console.WriteLine("enter the second word");
            string word1 = Console.ReadLine();
            if (word == word1)
            {
                Console.WriteLine("words are same");
            }
            else
            {
                Console.WriteLine("Words are not same");
            }
        }
    }
}
