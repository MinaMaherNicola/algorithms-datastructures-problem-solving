using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Console.Chapters.Ch1
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int number)
        {
            int left = 0, right = array.Length - 1, mid =  0;
            while (left <= right)
            {
                mid = UpdateMid(right, left);
                if (array[mid] == number)
                {
                    return mid;
                }
                else if (array[mid] < number)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        private static int UpdateMid(int right, int left)
        {
            return (int)Math.Round(((decimal)right + left) / 2.0M);
        }
    }
}
