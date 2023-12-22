using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Write a program in C# to find the total number of odd and even numbers accepted from the user.
namespace Assignments
{
    internal class Question5cs
    {
        static void Main(string[] args)
        {
            
        
            int ocount = 0, ecount = 0;

            Console.WriteLine("Enter Values");
         
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }
            }
            Console.WriteLine("Total Even Numbers:" + ecount);
            Console.WriteLine("Total Odd Numbers:" + ocount);
            Console.ReadLine();



        }
    }
}
