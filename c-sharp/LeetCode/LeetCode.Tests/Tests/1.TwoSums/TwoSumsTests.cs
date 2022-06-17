using LeetCode.Console.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Tests
{
    public class TwoSumsTests
    {
        private readonly TwoSums twoSums;

        public TwoSumsTests()
        {
            twoSums = new();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 0, 2 })]
        [InlineData(new int[] { 1, 2, 3 }, 5, new int[] { 1, 2 })]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 10, new int[] { 4, 6 })]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 15, new int[] { -1, -1 })]
        public void Test_Cases(int[] nums, int target, int[] answer)
        {
            var result = twoSums.TwoSum(nums, target);

            Assert.True(IsTwoArraysEqual(result, answer));
        }

        private bool IsTwoArraysEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
