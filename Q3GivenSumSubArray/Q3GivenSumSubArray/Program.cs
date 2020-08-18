using System;

namespace Q3GivenSumSubArray
{
    class Program
    {
		static void GivenSumSubArray(int[] a, int sum)
		{
			int currentSum = 0;
			int startIdx = 0;
			bool matchFound = false;
			for (int i = 0; i < a.Length; i++)
			{
				currentSum += a[i];
				while (currentSum > sum && startIdx < i)
				{
					currentSum -= a[startIdx];
					startIdx++;
				}
				if (currentSum == sum)
				{
					Console.WriteLine($"Sum found between indexes {startIdx} and {i}");
					matchFound = true;
					break;
				}

			}
			if (!matchFound)
			{
				Console.WriteLine("No subarray found");
			}
		}
        static void Main(string[] args)
        {
			int[] arr1 = { 1, 4, 20, 3, 10, 5 };
			GivenSumSubArray(arr1, 33); //2 and 4
			GivenSumSubArray(arr1, 18); //3 and 5
			GivenSumSubArray(arr1, 41); //no match
			int[] arr2 = { 1, 4, 0, 0, 3, 10, 5 };
			GivenSumSubArray(arr2, 7); //1 and 4
			GivenSumSubArray(arr2, 9); //no match
			GivenSumSubArray(arr2, 15); //5 and 6
			int[] arr3 = { 1, 4 };
			GivenSumSubArray(arr3, 0); //no match
			int[] arr4 = { 1, 0, 0, 0, 0, 0 };
			GivenSumSubArray(arr4, 0); // 1 and 1
			int[] arr5 = { 0, 0, 0, 0, 0, 0 };
			GivenSumSubArray(arr5, 0); // 0 and 0
		}

	}
}
