using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Console.Problems._217.ContainsDuplicate
{
    public class ContainsDuplicateProblem
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> appearance = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (appearance.ContainsKey(nums[i]))
                {
                    appearance[nums[i]]++;
                    if (appearance[nums[i]] > 1)
                        return true;
                }
                else
                {
                    appearance[nums[i]] = 1;
                }

            }
            return false;
        }
    }
}
