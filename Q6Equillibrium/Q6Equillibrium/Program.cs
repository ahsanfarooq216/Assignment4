using System;

namespace Q6Equillibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { -7, 1, 5, 2, -4, 3, 0 };
            Console.WriteLine(Equilibrium(arr1, 7)); //3
            int[] arr2 = { 4, 6, 1, 5, 5 }; //2
            Console.WriteLine(Equilibrium(arr2, 5));
            int[] arr3 = { 4, 6, 1, 5, 2, 4 }; //-1
            Console.WriteLine(Equilibrium(arr3, 6)); 
            int[] arr4 = { 2, 1, 2, 1 }; //-1
            Console.WriteLine(Equilibrium(arr4, 4));
            int[] arr5 = { 5, 2, 3 }; //-1
            Console.WriteLine(Equilibrium(arr5, 3));
        }

        public static int Equilibrium(int [] arr, int n)
        {
            int arraySum = 0;
            for (int i =0; i < n; i++)
            {
                arraySum += arr[i];
            }

            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                arraySum -= arr[i];
                if(leftSum == arraySum)
                {
                    return i;
                }
                leftSum += arr[i];
            }
            return -1;
        }
    }
}
