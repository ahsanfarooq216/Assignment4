using System;

namespace Q9SpiralPrint2DArray
{
    class Program
    {
        /*Given a 2D array, print it in spiral form. See the following examples:        
        1    2   3   4                                          1   2   3   4  5   6
        5    6   7   8                                          7   8   9  10  11  12
        9   10  11  12                                          13  14  15 16  17  18
        13  14  15  16
        Output:                                                 Output:
        1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10                  1 2 3 4 5 6 12 18 17 16 15 14 13 7 8 9 10 11
        */
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2, 3, 4 },
                            { 5, 6, 7, 8 },
                            { 9, 10, 11, 12},
                            { 13,  14,  15, 16} };
            PrintSpiral(arr1);
            int[,] arr2 = { { 1, 2, 3, 4, 5, 6 },
                            { 7, 8, 9, 10, 11, 12 },
                            { 13, 14, 15, 16, 17, 18 } };
            PrintSpiral(arr2);
        }

        static void PrintSpiral(int[,] a)
        {
            int startRowIdx = 0;
            int endRowIdx = a.GetLength(0)-1;
            int startColIdx = 0;
            int endColIdx = a.GetLength(1)-1;
            while(startColIdx <= endRowIdx && startRowIdx <= endRowIdx)
            {
                //print first of the remaining rows (go right)
                for (int i = startColIdx; i <= endColIdx; i++)
                {
                    Console.Write($"{a[startRowIdx, i]} ");
                }
                startRowIdx++;
                //print last of the remaining columns (go down)
                for(int i = startRowIdx; i <= endRowIdx; i++)
                {
                    Console.Write($"{a[i, endColIdx]} ");
                }
                endColIdx--;
                //print last of the remaianing rows (go left)
                if (startRowIdx <= endRowIdx) {
                    for(int i = endColIdx; i >= startColIdx; i--)
                    {
                        Console.Write($"{a[endRowIdx, i]} ");
                    }
                    endRowIdx--;
                }
                //print first of the remaining columns (go up)
                if(startColIdx <= endColIdx)
                {
                    for(int i = endRowIdx; i >= startRowIdx; i--)
                    {
                        Console.Write($"{a[i, startColIdx]} ");
                    }
                    startColIdx++;
                }
            }
            Console.WriteLine();
        }
    }
}
