using System;
using System.Collections.Generic;

namespace Q4GivenSumSubArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr1 = { 10, 2, -2, -20, 10 };
            GivenSumSubArray2(arr1, -10); //0 and 3
            GivenSumSubArray2(arr1, 3); //no match
            int [] arr2 = { 3, 10, 2, -2, -20, 10 };
            GivenSumSubArray2(arr2, -10); //1 nd 4
            int[] arr3 = { 4, 3, 10, 2, -2, -20, 10 };
            GivenSumSubArray2(arr3, -10); //2 nd 5
            int[] arr4 = { -7, 1, 5, 2, -4, 3, 0, 100 };
            GivenSumSubArray2(arr4, -6); //0 and 1
            GivenSumSubArray2(arr4, 37); //no match
            GivenSumSubArray2(arr4, 6); //1 and 2
            GivenSumSubArray2(arr4, 3); //2 and 4
            GivenSumSubArray2(arr4, -2); //3 and 4
            GivenSumSubArray2(arr4, 0); //0 and 5
            GivenSumSubArray2(arr4, 91); //no match
            GivenSumSubArray2(arr4, 101); //3 and 7
        }

        static void GivenSumSubArray2(int[] a, int sum)
        {
			int currentSum = 0;
			int startIdx = 0; //of subArray
            bool matchFound = false;
            var sumIdxMap = new Dictionary<int, int>();
			for (int i = 0; i < a.Length; i++)
			{
				currentSum += a[i];
                if (currentSum == sum)
                {
                    Console.WriteLine($"/nSum found between indexes {startIdx} and {i}");
                    matchFound = true;
                    break;
                }
                if (sumIdxMap.ContainsKey(currentSum - sum))
                {
                    startIdx = sumIdxMap[currentSum - sum] + 1;
                    Console.WriteLine($"/nSum found between indexes {startIdx} and {i}");
                    matchFound = true;
                    break;
                }
                sumIdxMap[currentSum] = i;
            }
            if (!matchFound)
            {
                Console.WriteLine("No subarray with given sum exists");
            }

		}
    }
}
