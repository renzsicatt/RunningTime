using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RunningTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the number of elements: ");
            int elementCount = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[elementCount];
            for(int x = 0; x< elementCount; x++)
            {
                Console.Write("Element number " + (x+1).ToString() + ": ");
                arr[x] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(arr);
            Console.ReadKey();
        }

        static void Sort(int[] arr)
        {
            int[] sort = { 2, 1, 3, 1, 2 };
            int shiftCount = 0;
            for (int ctr = 1; ctr <= sort.Length - 1; ctr++)
            {
                int value = sort[ctr];
                int ctr2 = ctr - 1;
                int ctrTemp = ctr;

                while (ctr2 >= 0)
                {
                    int value2 = sort[ctr2];
                    if (value < sort[ctr2])
                    {
                        sort[ctr2] = value;
                        sort[ctrTemp] = value2;
                        shiftCount++;
                    }
                    ctrTemp--;
                    ctr2--;
                }
            }
            Console.WriteLine("Result : " + shiftCount.ToString());
        }
    }
}
