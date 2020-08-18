using System;

namespace Q2MissingNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr1 = { 19, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 29, 22, 23, 24, 25, 26, 27, 28, 21, 30 }; //1
            int [] arr2 = { 15, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 14, 1, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27}; //12
            int [] arr3 = { 10, 2, 3, 5, 6, 7, 8, 9, 1 }; //4
            int [] arr4 = { 1, 5, 3, 4, 2, 7 }; //6
            int [] arr5 = { 1, 2, 4, 5, 6, 17, 8, 9, 10, 11, 12, 13, 14, 15, 16, 7, 18, 19, 20, 21, 22 }; //3
            int [] arr6 = { 3, 4, 1 }; //2
            Console.WriteLine(MissingNum(arr1));
            Console.WriteLine(MissingNum(arr2));
            Console.WriteLine(MissingNum(arr3));
            Console.WriteLine(MissingNum(arr4));
            Console.WriteLine(MissingNum(arr5));
            Console.WriteLine(MissingNum(arr6));
        }

        static int MissingNum(int [] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            return (((num.Length+1) * (num.Length + 2)) / 2) - sum;
        }
    }
}
