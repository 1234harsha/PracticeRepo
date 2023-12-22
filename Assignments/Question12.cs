using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");

            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    
}
}
