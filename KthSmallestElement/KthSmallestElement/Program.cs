using System;

namespace KthSmallestElement
{
    class Program
    {
        /* Given an array and a number k where k is smaller than size of array, we need to find the k’th smallest element in the given array.
         * It is given that ll array elements are distinct. Examples: Input: arr[] = {7, 10, 4, 3, 20, 15}; k = 3; Output: 7
         * Input: arr[] = {7, 10, 4, 3, 20, 15}; k = 4; Output: 10
         */
        static void Main(string[] args)
        {
            int [] arr1 = { 7, 10, 4, 3, 20, 15 };
            Console.WriteLine(KthSmallestElement(arr1, 3));
            Console.WriteLine(KthSmallestElement(arr1, 4));
        }

        static int KthSmallestElement(int [] a, int k)
        {
            Array.Sort(a);
            return a[k - 1];
        }
    }
}
