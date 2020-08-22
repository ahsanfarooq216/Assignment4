using System;

namespace Q6Equillibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { -7, 1, 5, 2, -4, 3, 0 };
            Console.WriteLine(Equilibrium(arr1)); //3
            int[] arr2 = { 4, 6, 1, 5, 5 }; //2
            Console.WriteLine(Equilibrium(arr2));
            int[] arr3 = { 4, 6, 1, 5, 2, 4 }; //-1
            Console.WriteLine(Equilibrium(arr3)); 
            int[] arr4 = { -1, -1, -1, 0, 1, 1 };
            Console.WriteLine(Equilibrium(arr4)); 
            int[] arr5 = { 2, 1, 2, 1 }; //-1
            Console.WriteLine(Equilibrium(arr5));
            int[] arr6 = { 5, 2, 3 }; //-1
            Console.WriteLine(Equilibrium(arr6));
            int[] arr7 = { 0, 4 };
            Console.WriteLine(Equilibrium(arr7));
        }

        public static int Equilibrium(int [] a)
        {
            int arraySum = 0;
            for (int i =0; i < a.Length; i++)
            {
                arraySum += a[i];
            }

            int leftSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                arraySum -= a[i];
                if(leftSum == arraySum)
                {
                    return i;
                }
                leftSum += a[i];
            }
            return -1;
        }
    }
}
