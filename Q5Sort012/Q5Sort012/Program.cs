using System;

namespace Q5Sort012
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 2, 2, 1, 1, 1, 0, 0, 0 };
            Sort012(arr1);
            int[] arr2 = { 1, 2, 0, 2, 1, 0, 0, 2, 1 };
            Sort012(arr2);
        }

        //static void Sort012(int [] a)
        //{
        //    printArray(a);
        //    int count0s = 0;
        //    int count1s = 0;
        //    int count2s = 0;

        //    for(int i = 0; i < a.Length; i++)
        //    {
        //        if(a[i] == 0)
        //        {
        //            count0s++;
        //        }
        //        if (a[i] == 0)
        //        {
        //            count1s++;
        //        }
        //        if (a[i] == 0)
        //        {
        //            count2s++;
        //        }
        //    }
        //    for (int i = 0; i < count0s; i++)
        //    {
        //        a[i] = 0;
        //    }
        //    for (int i = count0s; i < (count0s+count1s); i++)
        //    {
        //        a[i] = 1;
        //    }
        //    for (int i = (count0s + count1s); i < a.Length; i++)
        //    {
        //        a[i] = 2;
        //    }
        //    printArray(a);
        //}

        static void Sort012(int[] a)
        {
            printArray(a);
            int i = 0, j = 0, k = a.Length - 1;

            while (j <= k)
            {
                int temp;
                if (a[j] == 0)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j++;
                }
                else if (a[j] == 1)
                {
                    j++;
                }
                else
                {
                    temp = a[j];
                    a[j] = a[k];
                    a[k] = temp;
                    k--;
                }
            printArray(a);
            }
            Console.WriteLine("=================");
        }
        static void printArray(int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
    }
}
