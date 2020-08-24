using System;

namespace Q7Leaders
{
    class Program
    {
        /* Write a program to print all the LEADERS in the array. An element is leader if it is greater than all the elements to its right side.
         * And the rightmost element is always a leader. For example int the array {16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2.*/
        static void Main(string[] args)
        {
            int[] arr1 = { 16, 17, 4, 3, 5, 2 };
            Leaders(arr1); //2 5 17
            int[] arr2 = { 7, 1, 2, 3, 5, 6, 6, 4 };
            Leaders(arr2); //4 6 7
            int[] arr3 = { 19 };
            Leaders(arr3); //19
        }

        static void Leaders(int [] a)
        {
            int leader = int.MinValue;
            for(int i = a.Length-1; i >= 0; i--)
            {
                if(a[i] > leader)
                {
                    leader = a[i];
                    Console.Write($"{leader} ");
                }
            }
            Console.WriteLine();
        }
    }
}
