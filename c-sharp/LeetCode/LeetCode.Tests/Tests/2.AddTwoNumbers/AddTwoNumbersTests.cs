using LeetCode.Console.Problems._2.AddTwoNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static LeetCode.Console.Problems._2.AddTwoNumbers.AddTwoNumbersProblem;

namespace LeetCode.Tests.Tests._2.AddTwoNumbers
{
    public class AddTwoNumbersTests
    {
        private readonly AddTwoNumbersProblem addTwoNumbers;

        public AddTwoNumbersTests()
        {
            addTwoNumbers = new();
        }

        [Fact]
        public void Test_Case_One()
        {
            ListNode l1 = new(2, new(4, new(3)));
            ListNode l2 = new(5, new(6, new(4)));
            
            var output = addTwoNumbers.AddTwoNumbers(l1, l2);

            ListNode answer = new(7, new(0, new(8)));

            Assert.True(IsTwoListNodeEqual(output, answer));
        }

        [Fact]
        public void Test_Case_Two()
        {
            ListNode l1 = new(1, new(5, new(4)));
            ListNode l2 = new(9, new(2, new(7)));

            var output = addTwoNumbers.AddTwoNumbers(l1, l2);

            ListNode answer = new(8, new(1, new(1)));

            Assert.True(IsTwoListNodeEqual(output, answer));
        }

        private bool IsTwoListNodeEqual(ListNode l1, ListNode l2)
        {
            var pointer1 = l1;
            var pointer2 = l2;
            List<int> list1 = new();
            List<int> list2 = new();
            while (pointer1 != null)
            {
                list1.Add(pointer1.val);
                pointer1 = pointer1.next;
            }
            while (pointer2 != null)
            {
                list2.Add(pointer2.val);
                pointer2 = pointer2.next;
            }
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                    return false;
            }
            return true;
        }
    }
}
