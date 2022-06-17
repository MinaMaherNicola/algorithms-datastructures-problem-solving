using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Console.Problems._2.AddTwoNumbers
{
    public class AddTwoNumbersProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string stringL1 = ReverseString(TurnListNodeIntoString(l1));
            string stringL2 = ReverseString(TurnListNodeIntoString(l2));

            var result = System.Numerics.BigInteger.Parse(stringL1) + System.Numerics.BigInteger.Parse(stringL2);
            string resultReversed = System.Numerics.BigInteger.Parse(ReverseString(result.ToString())).ToString();
            ListNode output = new(resultReversed[0] - '0');
            var pointer = output;
            for(int i = 1; i < resultReversed.Length; i++)
            {
                pointer.next = new(resultReversed[i] - '0');
                pointer = pointer.next;
            }
            return output;
        }
        private string TurnListNodeIntoString(ListNode list)
        {
            var pointer = list;
            string output = "";
            while (pointer != null)
            {
                output += pointer.val;
                pointer = pointer.next;
            }
            return output;
        }

        private string ReverseString(string s)
        {
            string output = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                output += s[i];
            }
            return output;
        }
    }
}
