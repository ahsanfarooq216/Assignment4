using System;

namespace MaxSumContSubArray
{
	class Program
	{
		static void Main(String[] args)
		{
			int[] arr1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 }; //6
			Console.WriteLine($"1\tActual: {MaxContiguousSum(arr1)}\tExpected: 6");
			int[] arr2 = { -10, 2, 3, -2, 0, 5, -15 }; //8
			Console.WriteLine($"2\tActual: {MaxContiguousSum(arr2)}\tExpected: 8");
			int[] arr3 = { 6, -10, 5, 3, -2, 0, -5, 14, -5, 5 }; //15
			Console.WriteLine($"3\tActual: {MaxContiguousSum(arr3)}\tExpected: 15");
			int[] arr4 = { -43, 10, -2, 0, -4, -3, 200 }; //201
			Console.WriteLine($"4\tActual: {MaxContiguousSum(arr4)}\tExpected: 201");
			int[] arr5 = { -2, -3, 4, -1, -2, 1, 5, -3 }; //7
			Console.WriteLine($"5\tActual: {MaxContiguousSum(arr5)}\tExpected: 7");
			int[] arr6 = { -3, -2, -1, -2, -3 }; //-1
			Console.WriteLine($"6\tActual: {MaxContiguousSum(arr6)}\tExpected: -1");
			int[] arr7 = { -4 - 3 - 2 - 1 }; //-1
			Console.WriteLine($"7\tActual: {MaxContiguousSum(arr7)}\tExpected: -1");
			int[] arr8 = { 1, 2, 3, -2, 5 }; //9
			Console.WriteLine($"7\tActual: {MaxContiguousSum(arr8)}\tExpected: 9");
		}
        //public static int MaxContiguousSum(int[] a)
        //{
        //	int max_so_far = a[0];
        //	int curr_max = a[0];

        //	for (int i = 1; i < a.Length; i++)
        //	{
        //		curr_max = Math.Max(a[i], curr_max + a[i]);
        //		max_so_far = Math.Max(max_so_far, curr_max);
        //		Console.Write($"{max_so_far} ");
        //	}
        //	Console.WriteLine();
        //	return max_so_far;
        //}
        public static int MaxContiguousSum(int[] nums)
        {
            int currentSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }
            return maxSum;
        }

        //public static int MaxContiguousSum(int[] nums)
        //{
        //    int max_so_far = int.MinValue,
        //    max_ending_here = 0, start = 0,
        //    end = 0, s = 0;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        max_ending_here += nums[i];

        //        if (max_so_far < max_ending_here)
        //        {
        //            max_so_far = max_ending_here;
        //            start = s;
        //            end = i;
        //        }

        //        if (max_ending_here < 0)
        //        {
        //            max_ending_here = 0;
        //            s = i + 1;
        //        }
        //    }
        //    //Console.WriteLine("Maximum contiguous " +
        //    //                 "sum is " + max_so_far);
        //    //Console.WriteLine("Starting index "max_so_far +
        //    //                              start);
        //    //Console.WriteLine("Ending index " +
        //    //                              end);
        //    return max_so_far;
        //}
    }
}
