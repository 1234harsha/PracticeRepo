﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question14
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            //int arr2 = arr.Min();
            Console.WriteLine("Enter Array Values");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            int arr2 = arr.Min();
            Console.WriteLine(arr2);

        }
    }
}
