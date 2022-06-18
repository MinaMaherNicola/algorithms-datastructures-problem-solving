using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Console.Problems._4.MedianOfTwoSortedArrays
{
    public class MedianOfTwoSortedArraysProblem
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var newArr = new int[nums1.Length + nums2.Length];
            nums1.CopyTo(newArr, 0);
            nums2.CopyTo(newArr, nums1.Length);

            Array.Sort(newArr);
            if (newArr.Length % 2 == 0)
            {
                return (newArr[newArr.Length / 2] + newArr[(newArr.Length / 2) - 1]) / 2d;
            }
            return newArr[newArr.Length / 2];
        }
    }
}
