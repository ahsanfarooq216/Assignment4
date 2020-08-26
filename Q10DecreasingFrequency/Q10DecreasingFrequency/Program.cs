using System;
using System.Collections.Generic;
using System.Linq;

namespace Q10DecreasingFrequency
{
    class Program
    {
        /* Print the elements of an array in the decreasing frequency if 2 numbers have same frequency then print the one which came first. Examples:
         * Input: arr[] = {2, 5, 2, 6, -1, 99, 5, 8, 8, 8}     Output: arr[] = {8, 8, 8, 2, 2, 5, 5, 6, -1, 99}
         */
        static void Main(string[] args)
        {
            int [] arr1 = { 2, 5, 2, 6, -1, 99, 5, 8, 8, 8 };
            SortByFrequency(arr1);
        }

        public static void SortByFrequency(int [] a)
        {
            var table = new Dictionary<int, int>();
            foreach (var num in a)
            {
                if (table.ContainsKey(num))
                {
                    table[num]++;
                }
                else
                {
                    table.Add(num, 1);
                }
            }

            foreach (var pair in table.OrderByDescending(key => key.Value))
            {
                for(int i = 0; i < pair.Value; i++)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
        }
    }
}
