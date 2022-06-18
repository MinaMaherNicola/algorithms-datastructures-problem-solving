using LeetCode.Console.Problems._217.ContainsDuplicate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Tests.Tests._217.ContainsDuplicateTests
{
    public class ContainsDuplicateTests
    {
        private readonly ContainsDuplicateProblem containsDuplicate;

        public ContainsDuplicateTests()
        {
            containsDuplicate = new();
        }

        [Theory]
        [InlineData(new int[] { }, false)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 1, 1, 1, 1 }, true)]
        public void Test_Cases(int[] arr, bool answer)
        {
            var result = containsDuplicate.ContainsDuplicate(arr);

            Assert.Equal(result, answer);
        }
    }
}
