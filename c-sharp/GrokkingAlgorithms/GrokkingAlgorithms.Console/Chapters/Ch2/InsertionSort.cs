using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Console.Chapters.Ch2
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentMinimal = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[currentMinimal])
                    {
                        currentMinimal = j;
                    }
                }
                if (i == currentMinimal)
                    continue;

                int holder = arr[currentMinimal];
                arr[currentMinimal] = arr[i];
                arr[i] = holder;
            }
            return arr;
        }
    }
}
