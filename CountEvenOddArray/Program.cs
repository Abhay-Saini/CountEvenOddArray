using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEvenOddArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            count = 0;
            int Ocount;
            Ocount = 0;
            Console.WriteLine("Entre the size of array");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[s];


            for (int i = 0; i < s; i++)
            {
                Console.Write("Element {0}", i + " ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are ");
            for (int i = 0; i < s; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
          //  Console.WriteLine("count the numbers which are even");
            for (int i = 0; i < s; i++)
            {
                if(arr[i]%2==0)
                {
                    count++;
                }

            }
            Console.WriteLine("the total even number in the array are {0} ", count);





            for (int i = 0; i < s; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Ocount++;
                }

            }
            Console.WriteLine("the total Odd number in the array are {0} ", Ocount);

            Console.ReadLine();
        }
    }
}
