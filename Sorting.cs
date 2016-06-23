using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting3Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry1 = new int[5];
            int[] arry2 = new int[5];
            int[] sorted = new int[10];


            Console.WriteLine("enter 5 numbers ");

            for (int i = 0; i < 5; i++)
            {
                arry1[i] = Convert.ToInt32(Console.ReadLine());
            }




            Console.WriteLine("enter 5 numbers for array 2");

            for (int i = 0; i < 5; i++)
            {
                arry2[i] = Convert.ToInt32(Console.ReadLine());
            }


            sorted = arry1.Concat(arry2).ToArray();

            Console.WriteLine("sorted list is:");
            Array array = sorted;
            Array.Sort(array);
            foreach (int value in array)
            {
                Console.WriteLine(value);
                
            }
            
        }

    }
    }