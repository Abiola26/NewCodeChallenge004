using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCodeChallenge004
{
    internal class Target01
    {
        public int[] TwoSumReview(int[] nums, int target)
        {
            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (numsDictionary.TryGetValue(target - num, out int index))
                {
                    return new int[] { index, 1 };
                }
                numsDictionary[num] = i;
            }
            return null;

        }
    }
}
