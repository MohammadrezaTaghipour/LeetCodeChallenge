using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndString;
public class LargestNumberAtLeastTwiceofOthersSolution
{
    public int DominantIndex(int[] nums)
    {
        var maxIndex = FindMaxIndex(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == maxIndex)
                continue;
            if (nums[i] * 2 > nums[maxIndex])
                return -1;
        }
        return maxIndex;
    }

    int FindMaxIndex(int[] nums)
    {
        int maxIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}